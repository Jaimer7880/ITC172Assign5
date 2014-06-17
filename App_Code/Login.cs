using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for Login
/// </summary>
public class Login
{
    CommunityAssistEntities ca = new CommunityAssistEntities();
    string password;
    string userName;

    public Login(string pass, string user)
    {
        password = pass;
        userName = user;
    }

    public int ValidateLogin()
    {
        //personkey to return initally 0
        int pk = 0;

        //LINQ to extract personkey, passcode and hash from database
        var log = from p in ca.People
                  where p.PersonUsername == userName
                  && p.PersonPlainPassword == password
                  select new { p.PersonKey, p.Personpasskey, p.PersonUserPassword};
        //variables to store results from database
        int pCode = 0;
        Byte[] pWord = null;
        int personKey = 0;

        //loop throug results and assign values from var log
        //to our variables
       
        foreach (var s in log)
        {
            personKey = (int)s.PersonKey;
            pCode = (int)s.Personpasskey;
            pWord = (Byte[])s.PersonUserPassword;
        }
        //initial the PassWordHash
        PasswordHash ph = new PasswordHash();
        //send password and passcode to be hashed
        Byte[] newHash = ph.HashIt(password, pCode.ToString());


        if (pWord.SequenceEqual(newHash))
        {
            pk = personKey;
        }
        return pk;
    }

}