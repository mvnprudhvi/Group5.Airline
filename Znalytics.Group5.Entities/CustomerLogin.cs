using System;
using System.Collections.Generic;
 

namespace Znalytics.Group5.Entities
{
public class CustomerLogin
{
    private string _username;
    private string _password;
     

    public void SetUserName(String UserName)
    {
        this._username = UserName;
    }
    public string GetUserName()
    {
        return this._username;
    }
    public void setPassword(string Password)
    {
        this._password = Password;
    }
    public string GetPassword()
    {
        return this._password;
    }
    
}
}  