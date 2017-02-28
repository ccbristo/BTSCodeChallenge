<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BTSCodeChallenge.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/knockout-3.4.1.js"></script>
    <script type="text/javascript" src="Scripts/Controllers/Home/IndexController.js"></script>

    <div class="row">
    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Please Insert a New Person</h3>
        </div>
        <div class="panel-body">
            <div class="row" data-bind="with: CurrentPerson">
                <div class="col-lg-3">
                    <label>First Name:</label>
                    <input type="text" class="form-control" data-bind="value: FirstName"/>
                </div>
                <div class="col-lg-3">
                    <label>Last Name:</label>
                    <input type="text" class="form-control" data-bind="value: LastName" />
                </div>
                <div class="col-lg-3">
                    <label>Email:</label>
                    <input type="text" class="form-control" data-bind="value: Email" />
                </div>
                <div class="col-lg-3">
                    <label>Date of Birth:</label>
                    <input type="text" class="form-control" data-bind="value: DateOfBirth" />
                </div>
            </div>
        </div>
        <div class="panel-footer">
            <div class="row">
                <button type="button" class="btn btn-default" data-bind="click: SavePerson">Save</button>
            </div>
        </div>
    </div>
</div>

</asp:Content>
