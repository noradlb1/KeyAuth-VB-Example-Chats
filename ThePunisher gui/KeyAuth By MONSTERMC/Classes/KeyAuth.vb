Imports System
Imports System.Security.Cryptography
Imports System.Collections.Specialized
Imports System.Text
Imports System.IO
Imports System.Runtime.Serialization.Json
Imports System.Diagnostics
Imports System.Security.Principal
Imports System.Threading
Imports System.Collections.Generic
Imports System.Net
Imports System.Runtime.Serialization

Namespace KeyAuth
    Public Class api
        Public name, ownerid, secret, version As String

        Public Sub New(ByVal name As String, ByVal ownerid As String, ByVal secret As String, ByVal version As String)

            If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(ownerid) OrElse String.IsNullOrWhiteSpace(secret) OrElse String.IsNullOrWhiteSpace(version) Then
                [error]("Application not setup correctly. Please watch video link found in Program.cs")
                Environment.Exit(0)
            End If

            Me.name = name

            Me.ownerid = ownerid

            Me.secret = secret

            Me.version = version
        End Sub

#Region "structures"
        <DataContract>
        Private Class response_structure
            <DataMember>
            Public Property success As Boolean

            <DataMember>
            Public Property sessionid As String

            <DataMember>
            Public Property contents As String

            <DataMember>
            Public Property response As String

            <DataMember>
            Public Property message As String

            <DataMember>
            Public Property download As String

            <DataMember(IsRequired:=False, EmitDefaultValue:=False)>
            Public Property info As user_data_structure

            <DataMember(IsRequired:=False, EmitDefaultValue:=False)>
            Public Property appinfo As app_data_structure

            <DataMember>
            Public Property messages As List(Of msg)
        End Class

        Public Class msg
            Public Property message As String
            Public Property author As String
            Public Property timestamp As String
        End Class

        <DataContract>
        Private Class user_data_structure
            <DataMember>
            Public Property username As String

            <DataMember>
            Public Property ip As String
            <DataMember>
            Public Property hwid As String
            <DataMember>
            Public Property createdate As String
            <DataMember>
            Public Property lastlogin As String
            <DataMember>
            Public Property subscriptions As List(Of Data) ' array of subscriptions (basically multiple user ranks for user with individual expiry dates
        End Class

        <DataContract>
        Private Class app_data_structure
            <DataMember>
            Public Property numUsers As String
            <DataMember>
            Public Property numOnlineUsers As String
            <DataMember>
            Public Property numKeys As String
            <DataMember>
            Public Property version As String
            <DataMember>
            Public Property customerPanelLink As String
            <DataMember>
            Public Property downloadLink As String
        End Class
#End Region
        Private sessionid, enckey As String
        Private initzalized As Boolean
        ''' <summary>
        ''' Initializes the connection with keyauth in order to use any of the functions
        ''' </summary>
        Public Sub init()
            enckey = sha256(iv_key())
            Dim init_iv = sha256(iv_key())
            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("init"))},
    {"ver", encrypt(version, secret, init_iv)},
    {"hash", checksum(Process.GetCurrentProcess().MainModule.FileName)},
    {"enckey", encrypt(enckey, secret, init_iv)},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)


            If Equals(response, "KeyAuth_Invalid") Then
                [error]("Application not found")
                Environment.Exit(0)
            End If

            response = decrypt(response, secret, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then
                load_app_data(json.appinfo)
                sessionid = json.sessionid
                initzalized = True
            ElseIf Equals(json.message, "invalidver") Then
                app_data.downloadLink = json.download
            End If

        End Sub
#Region "Checkinit"
        Public Shared ReadOnly Property IsDebugRelease As Boolean
            Get
#If DEBUG Then
                Return True
#Else
                Return False
#End If
            End Get
        End Property

        Public Shared Property SurroundingClass As Object

        Public Sub Checkinit()
            If Not initzalized Then
                If IsDebugRelease Then
                    [error]("Not initialized Check if KeyAuthApp.init() does exist")
                Else
                    [error]("Please initialize first")

                End If


            End If

        End Sub
#End Region

        Public Sub register(ByVal username As String, ByVal pass As String, ByVal key As String)
            Checkinit()

            Dim hwid As String = WindowsIdentity.GetCurrent().User.Value

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("register"))},
    {"username", encrypt(username, enckey, init_iv)},
    {"pass", encrypt(pass, enckey, init_iv)},
    {"key", encrypt(key, enckey, init_iv)},
    {"hwid", encrypt(hwid, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then load_user_data(json.info)
        End Sub

        Public Sub login(ByVal username As String, ByVal pass As String)
            Checkinit()

            Dim hwid As String = WindowsIdentity.GetCurrent().User.Value

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("login"))},
    {"username", encrypt(username, enckey, init_iv)},
    {"pass", encrypt(pass, enckey, init_iv)},
    {"hwid", encrypt(hwid, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then load_user_data(json.info)
        End Sub


        Public Sub upgrade(ByVal username As String, ByVal key As String)
            Checkinit()

            Dim hwid As String = WindowsIdentity.GetCurrent().User.Value

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("upgrade"))},
    {"username", encrypt(username, enckey, init_iv)},
    {"key", encrypt(key, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            json.success = False
            load_response_struct(json)
        End Sub


        Public Sub license(ByVal key As String)
            Checkinit()

            Dim hwid As String = WindowsIdentity.GetCurrent().User.Value

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("license"))},
    {"key", encrypt(key, enckey, init_iv)},
    {"hwid", encrypt(hwid, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)

            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then load_user_data(json.info)
        End Sub
        ''' <summary>
        ''' checks if the current session is validated or not
        ''' </summary>
        Public Sub check()
            Checkinit()
            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("check"))},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
        End Sub

        Public Sub setvar(ByVal var As String, ByVal data As String)
            Checkinit()

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("setvar"))},
    {"var", encrypt(var, enckey, init_iv)},
    {"data", encrypt(data, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
        End Sub

        Public Function getvar(ByVal var As String) As String

            Checkinit()

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("getvar"))},
    {"var", encrypt(var, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return json.response
            Return Nothing
        End Function
        ''' <summary>
        ''' Bans the current logged in user
        ''' </summary>
        Public Sub ban()
            Checkinit()

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("ban"))},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
        End Sub

        Public Function var(ByVal varid As String) As String
            Checkinit()

            Dim hwid As String = WindowsIdentity.GetCurrent().User.Value

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("var"))},
    {"varid", encrypt(varid, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return json.message
            Return Nothing
        End Function

        Public Function chatget(ByVal channelname As String) As List(Of msg)
            Checkinit()

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("chatget"))},
    {"channel", encrypt(channelname, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return json.messages
            Return Nothing
        End Function

        Public Function chatsend(ByVal msg As String, ByVal channelname As String) As Boolean
            Checkinit()

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("chatsend"))},
    {"message", encrypt(msg, enckey, init_iv)},
    {"channel", encrypt(channelname, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return True
            Return False
        End Function
        ''' <summary>
        ''' Checks if the current ip address/hwid is blacklisted
        ''' </summary>
        ''' <returns>If found blacklisted returns true if not false</returns>
        Public Function checkblack() As Boolean
            Checkinit()
            Dim hwid As String = WindowsIdentity.GetCurrent().User.Value

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"))},
    {"hwid", encrypt(hwid, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)
            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return True
            Return False
        End Function

        Public Function webhook(ByVal webid As String, ByVal param As String, ByVal Optional body As String = "", ByVal Optional conttype As String = "") As String
            Checkinit()

            Dim init_iv = sha256(iv_key())

            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("webhook"))},
    {"webid", encrypt(webid, enckey, init_iv)},
    {"params", encrypt(param, enckey, init_iv)},
    {"body", encrypt(body, enckey, init_iv)},
    {"conttype", encrypt(conttype, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            Dim response = req(values_to_upload)

            response = decrypt(response, enckey, init_iv)

            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return json.response
            Return Nothing
        End Function

        Public Function download(ByVal fileid As String) As Byte()
            Checkinit()

            Dim init_iv = encryption.sha256(encryption.iv_key())


            Dim response = req(values_to_upload)

            response = encryption.decrypt(response, enckey, init_iv)

            Dim json = response_decoder.string_to_generic(Of response_structure)(response)
            load_response_struct(json)
            If json.success Then Return encryption.str_to_byte_arr(json.contents)
            Return Nothing
        End Function

        Public Sub log(ByVal message As String)
            Checkinit()

            Dim init_iv = sha256(iv_key())
            Dim values_to_upload = New NameValueCollection From {
    {"type", byte_arr_to_str(Encoding.Default.GetBytes("log"))},
    {"pcuser", encrypt(Environment.UserName, enckey, init_iv)},
    {"message", encrypt(message, enckey, init_iv)},
    {"sessionid", byte_arr_to_str(Encoding.Default.GetBytes(sessionid))},
    {"name", byte_arr_to_str(Encoding.Default.GetBytes(name))},
    {"ownerid", byte_arr_to_str(Encoding.Default.GetBytes(ownerid))},
    {"init_iv", init_iv}
}

            req(values_to_upload)
        End Sub
        Public Shared Function checksum(ByVal filename As String) As String
            Dim result As String
            Using md As MD5 = MD5.Create()
                Using fileStream = File.OpenRead(filename)
                    Dim value = md.ComputeHash(fileStream)
                    result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant()
                End Using
            End Using
            Return result
        End Function
        Public Shared Sub [error](ByVal message As String)
            Call Process.Start(New ProcessStartInfo("cmd.exe", $"/c start cmd /C ""color b && title Error && echo {message} && timeout /t 5""") With {
    .CreateNoWindow = True,
    .RedirectStandardOutput = True,
    .RedirectStandardError = True,
    .UseShellExecute = False
})
            Environment.Exit(0)

        End Sub
        Private Shared Function req(ByVal post_data As NameValueCollection) As String
            Try
                Using client As WebClient = New WebClient()
                    Dim raw_response = client.UploadValues("https://keyauth.win/api/1.0/", post_data)

                    Return Encoding.Default.GetString(raw_response)
                End Using
            Catch webex As WebException
                Dim response = CType(webex.Response, HttpWebResponse)
                Select Case response.StatusCode
                    Case CType(429, HttpStatusCode) ' client hit our rate limit
                        Thread.Sleep(1000)
                        Return SurroundingClass.req(post_data) ' site won't resolve. you should use keyauth.uk domain since it's not blocked by any ISPs
                    Case Else
                        [error]("Connection failure. Please try again, or contact us for help.")
                        Environment.Exit(0)
                        Return ""
                End Select
            End Try
        End Function


        Private Shared Function raw_response() As Byte()
            Throw New NotImplementedException()
        End Function

#Region "app_data"
        Public app_data As app_data_class = New app_data_class()

        Public Class app_data_class
            Public Property numUsers As String
            Public Property numOnlineUsers As String
            Public Property numKeys As String
            Public Property version As String
            Public Property customerPanelLink As String
            Public Property downloadLink As String
        End Class

        Private Sub load_app_data(ByVal data As app_data_structure)
            app_data.numUsers = data.numUsers
            app_data.numOnlineUsers = data.numOnlineUsers
            app_data.numKeys = data.numKeys
            app_data.version = data.version
            app_data.customerPanelLink = data.customerPanelLink
        End Sub
#End Region

#Region "user_data"
        Public user_data As user_data_class = New user_data_class()

        Public Class user_data_class
            Public Property username As String
            Public Property ip As String
            Public Property hwid As String
            Public Property createdate As String
            Public Property lastlogin As String
            Public Property subscriptions As List(Of Data) ' array of subscriptions (basically multiple user ranks for user with individual expiry dates
        End Class
        Public Class Data
            Public Property subscription As String
            Public Property expiry As String
            Public Property timeleft As String
        End Class

        Private Sub load_user_data(ByVal data As user_data_structure)
            user_data.username = data.username
            user_data.ip = data.ip
            user_data.hwid = data.hwid
            user_data.createdate = data.createdate
            user_data.lastlogin = data.lastlogin
            user_data.subscriptions = data.subscriptions ' array of subscriptions (basically multiple user ranks for user with individual expiry dates 
        End Sub
#End Region
        Public Function expirydaysleft() As String
            Checkinit()

            Dim dtDateTime As Date = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local)
            dtDateTime = dtDateTime.AddSeconds(Long.Parse(user_data.subscriptions(0).expiry)).ToLocalTime()
            Dim difference = dtDateTime - Date.Now
            Return Convert.ToString(difference.Days & " Days " & difference.Hours & " Hours Left")
        End Function

#Region "response_struct"
        Public response As response_class = New response_class()

        Public Class response_class
            Public Property success As Boolean
            Public Property message As String
        End Class

        Private Sub load_response_struct(ByVal data As response_structure)
            response.success = data.success
            response.message = data.message
        End Sub
#End Region

        Private response_decoder As json_wrapper = New json_wrapper(New response_structure())
        Private values_to_upload As NameValueCollection
    End Class

    Public Module encryption
        Public Function byte_arr_to_str(ByVal ba As Byte()) As String
            Dim hex As StringBuilder = New StringBuilder(ba.Length * 2)
            For Each b In ba
                hex.AppendFormat("{0:x2}", b)
            Next
            Return hex.ToString()
        End Function

        Public Function str_to_byte_arr(ByVal hex As String) As Byte()
            Try
                Dim NumberChars = hex.Length
                Dim bytes = New Byte(NumberChars / 2 - 1) {}
                For i = 0 To NumberChars - 1 Step 2
                    bytes(i / 2) = Convert.ToByte(hex.Substring(i, 2), 16)
                Next
                Return bytes
            Catch
                Console.WriteLine(vbLf & vbLf & "  The session has ended, open program again.")
                Thread.Sleep(3500)
                Environment.Exit(0)
                Return Nothing
            End Try
        End Function

        Public Function encrypt_string(ByVal plain_text As String, ByVal key As Byte(), ByVal iv As Byte()) As String
            Dim encryptor As Aes = Aes.Create()

            encryptor.Mode = CipherMode.CBC
            encryptor.Key = key
            encryptor.IV = iv

            Using mem_stream As MemoryStream = New MemoryStream()
                Using aes_encryptor As ICryptoTransform = encryptor.CreateEncryptor()
                    Using crypt_stream As CryptoStream = New CryptoStream(mem_stream, aes_encryptor, CryptoStreamMode.Write)
                        Dim p_bytes = Encoding.Default.GetBytes(plain_text)

                        crypt_stream.Write(p_bytes, 0, p_bytes.Length)

                        crypt_stream.FlushFinalBlock()

                        Dim c_bytes As Byte() = mem_stream.ToArray()

                        Return byte_arr_to_str(c_bytes)
                    End Using
                End Using
            End Using
        End Function

        Public Function decrypt_string(ByVal cipher_text As String, ByVal key As Byte(), ByVal iv As Byte()) As String
            Dim encryptor As Aes = Aes.Create()

            encryptor.Mode = CipherMode.CBC
            encryptor.Key = key
            encryptor.IV = iv

            Using mem_stream As MemoryStream = New MemoryStream()
                Using aes_decryptor As ICryptoTransform = encryptor.CreateDecryptor()
                    Using crypt_stream As CryptoStream = New CryptoStream(mem_stream, aes_decryptor, CryptoStreamMode.Write)
                        Dim c_bytes = str_to_byte_arr(cipher_text)

                        crypt_stream.Write(c_bytes, 0, c_bytes.Length)

                        crypt_stream.FlushFinalBlock()

                        Dim p_bytes As Byte() = mem_stream.ToArray()

                        Return Encoding.Default.GetString(p_bytes, 0, p_bytes.Length)
                    End Using
                End Using
            End Using
        End Function

        Public Function iv_key() As String
            Return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-", StringComparison.Ordinal))
        End Function

        Public Function sha256(ByVal r As String) As String
            Return byte_arr_to_str(New SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)))
        End Function

        Public Function encrypt(ByVal message As String, ByVal enc_key As String, ByVal iv As String) As String
            Dim _key = Encoding.Default.GetBytes(sha256(enc_key).Substring(0, 32))

            Dim _iv = Encoding.Default.GetBytes(sha256(iv).Substring(0, 16))

            Return encrypt_string(message, _key, _iv)
        End Function

        Public Function decrypt(ByVal message As String, ByVal enc_key As String, ByVal iv As String) As String
            Dim _key = Encoding.Default.GetBytes(sha256(enc_key).Substring(0, 32))

            Dim _iv = Encoding.Default.GetBytes(sha256(iv).Substring(0, 16))

            Return decrypt_string(message, _key, _iv)
        End Function
    End Module

    Public Class json_wrapper
        Public Shared Function is_serializable(ByVal to_check As Type) As Boolean
            Return to_check.IsSerializable OrElse to_check.IsDefined(GetType(DataContractAttribute), True)
        End Function

        Public Sub New(ByVal obj_to_work_with As Object)
            current_object = obj_to_work_with

            Dim object_type = current_object.GetType()

            serializer = New DataContractJsonSerializer(object_type)

            If Not is_serializable(object_type) Then Throw New Exception($"the object {current_object} isn't a serializable")
        End Sub

        Public Function string_to_object(ByVal json As String) As Object
            Dim buffer = Encoding.Default.GetBytes(json)

            'SerializationException = session expired

            Using mem_stream = New MemoryStream(buffer)
                Return serializer.ReadObject(mem_stream)
            End Using
        End Function

        Public Function string_to_generic(Of T)(ByVal json As String) As T
            Return string_to_object(json)
        End Function

        Private serializer As DataContractJsonSerializer

        Private current_object As Object
    End Class
End Namespace
