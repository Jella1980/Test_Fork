Public Class Form1


    Private Sub btnActivation_Click(sender As Object, e As EventArgs) Handles btnActivation.Click

        '' This serverTest application is for demonstration purspose only. '
        'The server side testing can be done after Putting the ServerDLLApp in a folder on the server
        ' Therafter get the full key from Rajendra Nimje. Put the key in the application folder in licese.lic file
        Dim activationkey As String
        Dim act As New ServerDLLApp.Activation
        'You can now generate the activation key for any desktop from the server itself automatically
        'by supplying the type of software pearl or diamond or Trial. Get the device ID and Serialization key from the desktop DLL 
        'through a webpage and return the activation key generated through the following method.
        Dim ast As New ServerDLLApp.FullLicense
        txtActivationKey.Text = "DeviceID =" + ast.DeviceID
        activationkey = act.getActivationKey("P", "deviceID", "SerialKey")

        txtActivationKey.Text = activationkey

        '99CG-T1GG-9BHF-87C3
    End Sub
End Class
