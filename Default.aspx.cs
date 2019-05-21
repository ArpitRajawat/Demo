using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void getMembers(string domainName, string groupName)
    {
<<<<<<< HEAD
        //Test
=======

    hello this will bring Conflict

        //Commecnt Added by Arpit
>>>>>>> 8c90ba8e34fbdf356615376422081c097c7ef5b6

        PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domainName);
        GroupPrincipal grp = GroupPrincipal.FindByIdentity(ctx, IdentityType.Name, groupName);



        if (grp == null)
        {
            // throw new System.ApplicationException("We did not find that group in that domain, perhaps the group resides in a different domain?");
            return;
        }

        IList<string> members = new List<String>();

        foreach (Principal p in grp.GetMembers(true))
        {

            Response.Write("<br> ----------------------<br> ");
            Response.Write("Name : " + p.Name + " | DistinguishedName : " + p.DistinguishedName + " | Context : " + p.Context + " | DisplayName : " + p.DisplayName + " | SamAccountName : " + p.SamAccountName + " | UserPrincipalName : " + p.UserPrincipalName + " | StructuralObjectClass : " + p.StructuralObjectClass);
            Response.Write("<br> ----------------------<br> ");



        }


    }









    public void GetGroups(string userName, string DomainType)
    {
        int chk = 0;
        List<string> result = new List<string>();

        PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain, DomainType);

        // find your user
        UserPrincipal user = UserPrincipal.FindByIdentity(yourDomain, userName);


        // if found - grab its groups
        if (user != null)
        {

            lblMsg.Text = "Current User is available on current domain";

        }
        else
        {
            lblMsg.Text = "Current User is not available on current domain";
        }




    }

    public void checkmemberDomainGroup(string domainName, string groupName, string username)
    {


        PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domainName);
        GroupPrincipal grp = GroupPrincipal.FindByIdentity(ctx, IdentityType.Name, groupName);



        if (grp == null)
        {
            lblMsg.Text = "Invalid group name";
        }

        IList<string> members = new List<String>();
        int cnt = 0;

        foreach (Principal p in grp.GetMembers(true))
        {
            if (username.ToString().Trim().ToLower() == p.Name.ToString().Trim().ToLower())
            // if (username.ToString().Trim().ToLower() == p.UserPrincipalName.ToString().Trim().ToLower().Split('@')[0].ToString())
            {
                cnt = 1;
                break;
            }
            else
            {
                cnt = 0;
            }


        }


        if (cnt == 1)
        {
            lblMsg.Text = "Current User is available on current domain on current group";

        }
        else
        {
            lblMsg.Text = "Current User is available on current domain on current group";
        }



    }


    public void getGroupList(string domainname)
    {
        PrincipalContext ctx = new PrincipalContext(ContextType.Domain, domainname);

        // define a "query-by-example" principal - here, we search for a GroupPrincipal 
        GroupPrincipal qbeGroup = new GroupPrincipal(ctx);



        // create your principal searcher passing in the QBE principal    
        PrincipalSearcher srch = new PrincipalSearcher(qbeGroup);

        // find all matches
        foreach (var found in srch.FindAll())
        {
            Response.Write("<br> ----------------------<br> ");
            Response.Write("Name : " + found.Name + " | DistinguishedName : " + found.DistinguishedName + " | Context : " + found.Context + " | DisplayName : " + found.DisplayName + " | SamAccountName : " + found.SamAccountName + " | UserPrincipalName : " + found.UserPrincipalName + " | StructuralObjectClass : " + found.StructuralObjectClass);
            Response.Write("<br> ----------------------<br> ");
        }
    }


    public void GetUsersGroups(string userName, string domainname)
    {


        // establish domain context
        PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain, domainname);

        // find your user
        UserPrincipal user = UserPrincipal.FindByIdentity(yourDomain, userName);

        // if found - grab its groups
        if (user != null)
        {
            PrincipalSearchResult<Principal> groups = user.GetAuthorizationGroups();

            // iterate over all groups
            foreach (Principal p in groups)
            {
                if (p is GroupPrincipal)
                {
                    Response.Write("<br> ----------------------<br> ");
                    Response.Write("Name : " + p.Name + " | DistinguishedName : " + p.DistinguishedName + " | Context : " + p.Context + " | DisplayName : " + p.DisplayName + " | SamAccountName : " + p.SamAccountName + " | UserPrincipalName : " + p.UserPrincipalName + " | StructuralObjectClass : " + p.StructuralObjectClass);
                    Response.Write("<br> ----------------------<br> ");
                }
            }
        }


    }


    public void CheckUserCredential(string userName, string password, string DomainType)
    {
        int chk = 0;
        List<string> result = new List<string>();

        PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain, DomainType);

        // find your user
        UserPrincipal user = UserPrincipal.FindByIdentity(yourDomain, userName);


        // if found - grab its groups
        if (user != null)
        {


            chk = 1;

        }
        else
        {
            chk = 0;
        }
        if (chk == 1)
        {
            bool isCredentialValid = false;

            // User's domain's credential achecking
            isCredentialValid = yourDomain.ValidateCredentials(userName, password);
            if (isCredentialValid)
                lblMsg.Text = "Valid Credential";
            else
                lblMsg.Text = "InValid Credential";
        }



    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        getMembers(txtDomainName.Text.Trim(), txtGroupName.Text.Trim());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        GetGroups(txtUser_Name.Text.Trim(), txt_DomainName.Text.Trim());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        checkmemberDomainGroup(txt_Domain_Name.Text.Trim(), txt_Group_Name.Text.Trim(), txt_User_Name.Text.Trim());
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        getGroupList(txtDomain_Name.Text.Trim());
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        GetUsersGroups(txt_u_nm.Text.Trim(), txt_d_nm.Text.Trim());
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        CheckUserCredential(txt_u_name.Text.Trim(), txtPassword.Text.Trim(), txt_d_name.Text.Trim());
    }
}