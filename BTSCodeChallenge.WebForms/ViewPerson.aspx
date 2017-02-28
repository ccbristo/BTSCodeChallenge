<%@ Page Title="This Is The Person You Saved" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPerson.aspx.cs" Inherits="BTSCodeChallenge.WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/knockout-3.4.1.js"></script>
    <script type="text/javascript" src="Scripts/Controllers/Home/ViewPersonController.js"></script>

    <h2><%: Title %>.</h2>  

    <div class="row" data-bind="with: CurrentPerson">
        <div class="col-lg-3">
            <label>First Name: </label>
            <label data-bind="text: FirstName"></label>
        </div>
        <div class="col-lg-3">
            <label>Last Name: </label>
            <label data-bind="text: LastName"></label>
        </div>
        <div class="col-lg-3">
            <label>Email: </label>
            <label data-bind="text: Email"></label>
        </div>
        <div class="col-lg-3">
            <label>Date of Birth: </label>
            <label data-bind="text: DateOfBirth"></label>
        </div>
    </div>
</asp:Content>
