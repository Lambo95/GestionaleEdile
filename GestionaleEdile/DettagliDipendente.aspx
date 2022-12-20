<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DettagliDipendente.aspx.cs" Inherits="GestionaleEdile.DettagliDipendente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container m-5"  runat="server">
        <div class="card mb-3">
            <div class="row g-0">
                <div class="col">
                    <div class="card-body">
                        <h4 class="card-title"><asp:Label ID="lblNome" runat="server" Font-Bold="true"></asp:Label></h4>
                        <hr />
                        <p> Indirizzo: <asp:Label ID="lblIndirizzo" runat="server" Font-Size="10"></asp:Label></p>
                        <p> CF: <asp:Label ID="lblCf" runat="server" Font-Size="10"></asp:Label></p>
                        <p> Coniugato: <asp:Label ID="lblConiugato" runat="server" Font-Size="10"></asp:Label></p>
                        <p> Figli: <asp:Label ID="lblFigli" runat="server" Font-Size="10"></asp:Label></p>
                        <p> Mansione: <asp:Label ID="lblMansione" runat="server" Font-Size="10"></asp:Label></p>
                        <p> Stipendio/Acconto: <asp:Label ID="lblStip" runat="server" Font-Size="10"></asp:Label></p>
                        <p> Periodo: <asp:Label ID="lblDate" runat="server" Font-Size="10"></asp:Label></p>
                        <p> Pagamento: <asp:Label ID="lblPag" runat="server" Font-Size="10"></asp:Label></p>
                        <hr />
                       
                    </div>
                </div>
            </div>
        </div>
    </div>
      <div class="row">
                    <div class="col pb-5" >
                            
                            <asp:Label ID="lblStipendio" runat="server" Text="Stipendio:" CssClass="form-label"></asp:Label>
                        <br />
                            <asp:CheckBox ID="ckbStipendio" runat="server"   />
                        <br />
                            
                            <asp:Label ID="lblPeriodo" runat="server" Text="Periodo:" CssClass="form-label"></asp:Label>
                            <asp:TextBox ID="txtPeriodo" runat="server" CssClass="form-control mb-2" ></asp:TextBox>

                            <asp:Label ID="lblPagamento" runat="server" Text="Pagamento:" CssClass="form-label"></asp:Label>
                            <asp:TextBox ID="txtSottotitolo" runat="server" CssClass="form-control mb-2" ></asp:TextBox>
                         <div>
                            <asp:Button ID="NuovoPagamento" runat="server" Text="Aggiungi pagamento" OnClick="NuovoPagamento_Click"  CssClass="btn btn-outline-primary"/>
                        </div>
                            <asp:Label ID="lblError" runat="server" Text="" Visible="false" ForeColor="red"></asp:Label>

                        </div>
                    </div>

</asp:Content>
