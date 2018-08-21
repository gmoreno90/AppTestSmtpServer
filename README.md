# AppTestSmtpServer
With this console app you can check if a SMTP server is working

In order to configure the tester only you need to get the file App.config and set the smtp server values

<AppTestSMTPServer.Properties.Settings>
      <setting name="SmtpServer" serializeAs="String">
        <value>##SMTP Address##</value>
      </setting>
      <setting name="SmtpPort" serializeAs="String">
        <value>587</value>
      </setting>
      <setting name="SmtpSSL" serializeAs="String">
        <value>True</value>
      </setting>
      <setting name="SmtpUser" serializeAs="String">
        <value>##UserNameAddress##</value>
      </setting>
      <setting name="SmtpEmail" serializeAs="String">
        <value>##EmailAddress##</value>
      </setting>
      <setting name="SmtpPassword" serializeAs="String">
        <value>##EmailPassword##</value>
      </setting>
      <setting name="SmtpDisplayName" serializeAs="String">
        <value>Testing SMTP Server</value>
      </setting>
      <setting name="ToAddress" serializeAs="String">
        <value>##emailAdresses to sent email##</value>
      </setting>
    </AppTestSMTPServer.Properties.Settings>
    
    
