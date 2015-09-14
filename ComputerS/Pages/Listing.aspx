<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="ComputerS.Pages.Listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ComputerS</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                foreach (ComputerS.Models.Computer computer in GetComputers())
                {
                    Response.Write(String.Format(@"
                        <div class='item'>
                            <h3>{0}</h3>
                            {1}
                            <h4>{2:c}</h4>
                        </div>",
                        computer.Name, computer.Description, computer.Price));
                }
            %>
        </div>
    </form>
     <div>
        <%
            //В коде используется цикл for для генерации элементов <a>, представляющих каждую страницу, для которой может быть отображен контент.
            
            for (int i = 1; i <= MaxPage; i++)
            {
                Response.Write(
                    String.Format("<a href='/Pages/Listing.aspx?page={0}' {1}>{2}</a>",
                        i, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
    </div>
</body>
</html>