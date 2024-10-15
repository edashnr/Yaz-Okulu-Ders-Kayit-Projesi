<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersListesi.aspx.cs" Inherits="YazOkuluDersler.DersListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Ders ID</th>
            <th>Ders AD</th>
            <th>Ders Minimum Kontenjan</th>
            <th>Ders Maximum Kontenjan</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Dersid") %></td>
                        <td><%#Eval("Dersad") %></td>
                          <td><%#Eval("Min") %></td>
                         <td><%#Eval("Max") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
