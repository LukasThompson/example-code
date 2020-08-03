<%@ Page Title="Beaner's Coffee - Turn Java Into Code" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="JavaHouse2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-color: #E95B26; color: #FFFFFF">
        <center>
        <table class="nav-justified">
            <tr>
                <td style="width: 204px; text-align: left; height: 39px;">Name:</td>
                <td style="width: 209px; height: 39px;">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 316px; height: 39px; font-size: 14px; color: #FF0000; text-align: left;">
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="* Please Enter Name" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                </td>
                <td style="height: 39px"></td>
            </tr>
            <tr>
                <td style="width: 204px; height: 36px; text-align: left;">Coffee Selection:</td>
                <td style="width: 209px; height: 36px;">
                    <asp:DropDownList ID="ddlCoffeeSelection" runat="server">
                        <asp:ListItem>Regular</asp:ListItem>
                        <asp:ListItem>Decaf</asp:ListItem>
                        <asp:ListItem>Vermont Maple</asp:ListItem>
                        <asp:ListItem>Mocha</asp:ListItem>
                        <asp:ListItem>Columbian</asp:ListItem>
                        <asp:ListItem>Kona Coffee</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="width: 316px; height: 36px;"></td>
                <td style="height: 36px"></td>
            </tr>
            <tr>
                <td style="width: 204px; vertical-align: top; text-align: left; height: 158px;">Coffee Size:</td>
                <td style="width: 209px; text-align: left; height: 158px;">
                    <asp:RadioButtonList ID="rblCoffeeSize" runat="server" Width="180px">
                        <asp:ListItem>Tall</asp:ListItem>
                        <asp:ListItem>Grande</asp:ListItem>
                        <asp:ListItem>Vente</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />

                </td>
                <td style="width: 316px; height: 158px; vertical-align: top; text-align: left;">
                    <table class="nav-justified">
                        <tr>
                            <td style="text-align: left">$2.59</td>
                        </tr>
                        <tr>
                            <td style="text-align: left; vertical-align: top;">$3.09</td>
                        </tr>
                        <tr>
                            <td style="text-align: left">$3.59</td>
                        </tr>
                    </table>
                </td>
                <td style="font-size: 14px; color: #FF0000; vertical-align: top; text-align: left; height: 158px;">
                    <asp:RequiredFieldValidator ID="rfvCoffeeSize" runat="server" ControlToValidate="rblCoffeeSize" ErrorMessage="* Please Select a Size"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top; text-align: left;">Additional Items:</td>
                <td style="width: 209px; text-align: left;">
                    <asp:CheckBoxList ID="cblAdditions" runat="server">
                        <asp:ListItem>Double Shot</asp:ListItem>
                        <asp:ListItem>Flavored Syrup</asp:ListItem>
                        <asp:ListItem>Whipped Cream</asp:ListItem>
                        <asp:ListItem>Soy Milk</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />

                </td>
                <td style="vertical-align: top; text-align: left; font-size: 14px;">* Each item is an additional $0.49</td>
                <td style="vertical-align: bottom; text-align: right">
                    
                    <asp:Button ID="btnOrder" runat="server" Height="48px" Text="Order" Width="137px" />
                    
                </td>
            </tr>
        </table>
            </center>
        <asp:Image ID="imgFooter" runat="server" Height="244px" ImageUrl="http://www.thefranchisecoach.net/f/beaners_coffee_logo.gif" Width="271px" ImageAlign="Top" />

    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblResults" runat="server" ForeColor="White" Text="Results are displayed in this panel. Thanks for coming in Stu your &quot;CoffeSize&quot; + &quot;CoffeeSelection&quot; will be right out!"></asp:Label>
    </div>

    <div class="row">
    </div>

    </div>
</asp:Content>
