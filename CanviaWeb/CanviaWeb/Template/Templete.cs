using CanviaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanviaWeb.Template
{
    public class Templete
    {
        enum Talen
        {
            Canvia = 1, Gamarra = 2, MINEDU = 3
        }


        public static string getTable(List<UserModel> arraylist)
        {
            // BuildMyString.com generated code. Please enjoy your string responsibly.
            try
            {
                var sb = "";

                foreach (UserModel user in arraylist)
                {
                    string lastemplate =

"            <tr role=\"row\" class=\"odd\">" +
"                <td>" +
"                    @Name" +
"                </td>" +
"                <td>   @LastName</td>" +
"                <td class=\"hidden-480\">@UserCode</td>" +
"                <td class=\"hidden-480\">@Email</td>" +
"                <td>@System</td>" +
"                <td>" +
"                    @status" +
"                </td>" +
"            </tr>" ;

                    lastemplate= lastemplate.Replace("@Name", user.Name);
                    lastemplate = lastemplate.Replace("@LastName", user.LastName);
                    lastemplate = lastemplate.Replace("@UserCode", user.UserCode);
                    lastemplate = lastemplate.Replace("@Email", user.Email);
                    if (user.IdSystem != null)
                    {
                        if (user.IdSystem.Equals("1")) { lastemplate.Replace("@System", Talen.Canvia.ToString()); }
                        else if (user.IdSystem.Equals("2")) { lastemplate = lastemplate.Replace("@System", Talen.Gamarra.ToString()); }
                        else if (user.IdSystem.Equals("3")) { lastemplate = lastemplate.Replace("@System", Talen.MINEDU.ToString()); }
                    }
                    else {
                        lastemplate = lastemplate.Replace("@System", "CanviaSsystemTest");

                    }

                    if (user.Status != null)
                    { 
                    if (user.Status.Equals("0"))
                        { lastemplate = lastemplate.Replace("@status", "<span class=\"label label-sm label-warning\">Expiring</span>"); }
                    else if (user.Status.Equals("1")) { lastemplate = lastemplate.Replace("@status","<span class=\"label label-sm label-success\">OK</span>"); }
                }
                    else
                {
                        lastemplate = lastemplate.Replace("@status", "<span class=\"label label-sm label-warning\">Expiring</span>");
                    }
                    sb = sb + lastemplate;
                    lastemplate = string.Empty;


                }
                return sb;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}