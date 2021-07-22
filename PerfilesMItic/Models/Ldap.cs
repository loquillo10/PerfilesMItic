using System.DirectoryServices;

namespace PerfilesMItic.Models
{

    public class Ldap
    {
        //Authentication LDAP EXTERNO
        string ldapserver = "192.168.201.23:389";
        string ldapbasedn = "o=mitic";
        string ldapuser = "cn=tra";
        string ldappassword = "Tera2020*";
        string ldapfilter = "(&(objectclass=people)(cn={0}))";


        string user = "pgonzalez";
        string password = "Loquillo4735280.";

        //        try 
        //	    {	        
        //		    string DN = "";
        //            using (DirectoryEntry entry = new DirectoryEntry("LDAP://" + ldapserver + "/" + ldapbasedn, ldapuser, ldappassword, AuthenticationTypes.None))
        //            {

        //            }
        //	    }
        //	    catch (global::System.Exception)
        //	    {

        //		    throw;
        //	    }



          }
    }
