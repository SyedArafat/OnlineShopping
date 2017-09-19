<%@ Page Title="" Language="C#" MasterPageFile="~/staffHome.Master" AutoEventWireup="true" CodeBehind="staffList.aspx.cs" Inherits="WebApplication1.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="userName" HeaderText="userName" SortExpression="userName" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="fullName" HeaderText="fullName" SortExpression="fullName" />
            <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" />
            <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
            <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:emsConnectionString %>" SelectCommand="SELECT * FROM [userTable] WHERE type='Staff'" DeleteCommand="DELETE FROM [userTable] WHERE [id] = @id" InsertCommand="INSERT INTO [userTable] ([userName], [email], [fullName], [phoneNumber], [address], [password], [type], [departmentId], [salary]) VALUES (@userName, @email, @fullName, @phoneNumber, @address, @password, @type, @departmentId, @salary)" UpdateCommand="UPDATE [userTable] SET [userName] = @userName, [email] = @email, [fullName] = @fullName, [phoneNumber] = @phoneNumber, [address] = @address, [password] = @password, [type] = @type, [departmentId] = @departmentId, [salary] = @salary WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="userName" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="fullName" Type="String" />
            <asp:Parameter Name="phoneNumber" Type="String" />
            <asp:Parameter Name="address" Type="String" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="type" Type="String" />
            <asp:Parameter Name="departmentId" Type="Int32" />
            <asp:Parameter Name="salary" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="userName" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="fullName" Type="String" />
            <asp:Parameter Name="phoneNumber" Type="String" />
            <asp:Parameter Name="address" Type="String" />
            <asp:Parameter Name="password" Type="String" />
            <asp:Parameter Name="type" Type="String" />
            <asp:Parameter Name="departmentId" Type="Int32" />
            <asp:Parameter Name="salary" Type="Decimal" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    
    </asp:Content>