<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Rcommers_web.Admin.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-sm-12 col-md-4">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title"> Category</h4>
                    <hr />

                    <div class="form-body">
                        <lable>Category Name</lable>
                        <div class="row">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <asp:TextBox ID="textCategoryName" runat="server" CssClass="form-control" placeholder="Enter Catagery Nmae"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ForeColor="Red" Font-Side="small"  Display="Dynamic" SetFocusOnError="true" ControlToValidate="textCategoryName" ErrorMessage="Category Name is required" ></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

         <div class="col-sm-12 col-md-8">
          <div class="card">
           <div class="card-body">
             <h4 class="card-title"> Category</h4>
         </div>
      </div>
      </div>

    </div>
</asp:Content>
