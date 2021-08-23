<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>App</title>
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,300italic,700,700italic" />
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.css" />
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/milligram/1.4.1/milligram.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="column">
                    <h1>App</h1>
                    <h4>People</h4>
                    <table>
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Full Name</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="repPersonRow" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#DataBinder.Eval(Container, "DataItem.Id")%></td>
                                        <td><%#DataBinder.Eval(Container, "DataItem.FullName")%></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                    
                </div>
            </div>
        </div>
    </form>
</body>
</html>
