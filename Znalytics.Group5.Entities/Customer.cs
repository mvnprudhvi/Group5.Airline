public class Registration
{
    private string _FullName;
    private string _UserName;
    private string _Password;
    private string _Email;
    private long _MobileNumber;
    private long _AadharNumber;
    private string _PanCardNumber;
    public void SetFullName(string value)
    {
        _FullName = value;
    }
    public string GetFullName()
    {
        return _FullName;
    }

    public void SetUserName(string value)
    {
        _UserName = value;
    }
    public string GetUserName()
    {
        return _UserName;
    }
    public void SetPassword(string value)
    {
        _Password = value;
    }
    public string GetPassword()
    {
        return _Password;
    }
    public void SetEmail(string value)
    {
        _Email = value;
    }
    public string GetEmail()
    {
        return _Email;
    }
    public void SetMobileNumber(long value)
    {
        _MobileNumber = value;
    }
    public long GetMobileNumber()
    {
        return _MobileNumber;
    }
    public void SetAadharNumber(long value)
    {
        _AadharNumber = value;
    }
    public long GetAadharNumber()
    {
        return _AadharNumber;
    }
    public void SetPanCardNumber(string value)
    {
        _PanCardNumber = value;
    }
    public string GetPanCardNumber()
    {
        return _PanCardNumber;
    }
}
