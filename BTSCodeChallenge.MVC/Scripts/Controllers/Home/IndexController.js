var Person = function() {
    var self = this;

    self.FirstName = ko.observable("");
    self.LastName = ko.observable("");
    self.Email = ko.observable("");
    self.DateOfBirth = ko.observable("");
};

var ViewModel = function () {
    var self = this;

    self.CurrentPerson = ko.observable(new Person());

    //Methods
    self.Init = function () {
        self.GetPerson();
    };

    self.AddPerson = function (personData) {
        var newPerson = new Person();

        newPerson.FirstName(personData.FirstName);
        newPerson.LastName(personData.LastName);
        newPerson.Email(personData.Email);
        newPerson.DateOfBirth(personData.DateOfBirth);

        self.CurrentPerson(newPerson);
    };

    //API Methods
    self.GetPerson = function () {
        $.ajax({
            url: "http://localhost:57850/api/Person/GetPerson",
            type: "GET",
            dataType: "json",
            success: function (data) {
                self.AddPerson(data);
            },
            error: function (request, error) {
                alert(error.responseJSON.Message);
            }
        });
    };

    self.SavePerson = function () {
        var json = ko.toJSON(self.CurrentPerson());

        $.ajax({
            url: "http://localhost:57850/api/Person/SavePerson",
            type: "POST",
            dataType: "json",
            contentType: "application/json",
            data: json,
            success: function (data) {
                alert(data);
            },
            error: function (request, error) {
                alert(error.responseJSON.Message);
            }
        });
    };

    self.Init();
};

$(document).ready(function () {
    ko.applyBindings(new ViewModel());
});