Quick start
-----------
Add your MailChimp API key to the Web.Config file and run the solution in Visual Studio 2010

```html
      <appSettings>
        <add key="apikey" value="YOUR-MAILCHIMP-API-KEY-HERE"/>
      </appSettings>
```


Pages
-----------
Settings -- shows you the default settings configuration (you can change these by adding your own in Web.Config or in the code)

Lists -- calls the MailChimp API method [`lists()`](http://apidocs.mailchimp.com/api/1.3/lists.func.php)

List -- from the Lists page click on any list to see each member's email address. Uses the [`listMembers()`](http://apidocs.mailchimp.com/api/1.3/listmembers.func.php) method 

From here you should be able to get going quickly.



References
-----------
[MailChimp API (MCAPI)](http://apidocs.mailchimp.com/api/)

[PerceptiveMCAPI .NET wrapper](http://perceptivemcapi.codeplex.com)