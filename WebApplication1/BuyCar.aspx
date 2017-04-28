<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyCar.aspx.cs" Inherits="WebApplication1.BuyCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10">
                <div class="row">
                    <div class="col-mid-12">
                        <div class="form-group">
                            <label>Brand</label>
                            <asp:DropDownList runat="server" AutoPostBack="true" ID="ddlBrand" CssClass="form-control dropdown" OnSelectedIndexChanged="ddlBrand_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Model</label>
                            <asp:DropDownList runat="server" OnSelectedIndexChanged="ddlModel_SelectedIndexChanged" ID="ddlModel" AutoPostBack="true" CssClass="dropdown form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Price</label>
                            <asp:TextBox runat="server" ID="txtPrice" Enabled="false" CssClass="form-control" />  
                        </div>
                        <div class="form-group">
                            <label>Quantity</label>
                            <asp:TextBox runat="server" ID="txtQuantity" CssClass="form-control" /> 
                        </div>
                        <div class="form-group">
                            <asp:Button Text="Bill" runat="server" ID="btnBill" CssClass="btn btn-primary" OnClick="btnBill_Click" />
                        </div>
                        <div class="form-group">
                            <label>Total Price</label>
                            <asp:TextBox runat="server" ID="txtTotal" CssClass="form-control" />  
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
    </div>
    </form>
</body>
</html>
