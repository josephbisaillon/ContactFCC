<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebContactFCC._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 317px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Contact FCC Leaders"></asp:Label>
    
    </div>
        <asp:CheckBoxList ID="MemberCheckedListBox" runat="server" Height="169px" Width="219px">
        </asp:CheckBoxList>
        <asp:Label ID="Label2" runat="server" Text="Full Name"></asp:Label>
        <br />
        <asp:TextBox ID="fullNameTextBox" runat="server" Height="19px" OnTextChanged="TextBox1_TextChanged" Width="120px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email Address"></asp:Label>
        <br />
        <asp:TextBox ID="emailTextBox" runat="server" Height="19px" Width="120px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Message"></asp:Label>
        <br />
        <asp:TextBox ID="messageTextBox" runat="server" Height="157px" OnTextChanged="messageTextBox_TextChanged" Width="691px" TextMode="MultiLine">As a Net-neutrality advocate, I support that the new rules you want to propose threaten the Internet’s free and open culture. I do not support your advocacy for the murder of the open Internet. The Federal Communications Commission should protect the people of the internet, not the rich and greedy corporations. As our founding father George Washington wrote: &quot;Few men have virtue to withstand the highest bidder.&quot; Prove me wrong.

</asp:TextBox>
        <asp:Label ID="SentMessageLabel" runat="server" BorderStyle="Double" Height="157px" Text="Label" Visible="False" Width="195px"></asp:Label>
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click1" Text="Submit to FCC Leaders" Width="253px" />
        </p>
    </form>
</body>
</html>
