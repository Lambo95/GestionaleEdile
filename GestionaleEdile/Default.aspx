<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GestionaleEdile._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>Gestionale Lavoratori</h1>
    </div>
    
    <asp:GridView ID="GridView1" runat="server" ItemType="GestionaleEdile.Dipendente" Visible="true" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Nome & Cognome">
                <ItemTemplate>
                    <p>
                      <a href="DettagliDipendente.aspx?IdDipendente=<%# Item.ID %>">  <%# Item.Nome %> <%# Item.Cognome %>  </a>
                    </p>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Indirizzo">
                <ItemTemplate>
                    <p>
                        <%# Item.Indirizzo %>
                    </p>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Codice Fiscale">
                <ItemTemplate>
                    <p>
                        <%# Item.CF %>
                    </p>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Coniugato">
                <ItemTemplate>
                    <p>
                        <%# Item.Coniugato %>
                    </p>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Figli">
                <ItemTemplate>
                    <p>
                        <%# Item.Figli %>
                    </p>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mansione">
                <ItemTemplate>
                    <p>
                        <%# Item.Mansione %>
                    </p>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

</asp:Content>
