/// <reference path="../knockoutjs.js" />



function CustomerController() {
    var self = this;

    const baseUrl = "api/CustomersApi";
    self.newCustomer = ko.observable(new CustomerModel());
    self.Customers = ko.observableArray([]);

    self.addCustomer = function () {
        console.log(self.newCustomer());
        console.log(ko.toJSON(self.newCustomer()));

        ajax.post(baseUrl, ko.toJSON( self.newCustomer())).
            done((result) => {
                self.Customers.push(new CustomerModel(result))
            });
    }
}

var ajax = {
    get: function (url, data) {
      return  $.ajax({
          method: "GET",
          url: url,


        });
    },
    post: function (url, data) {
     return  $.ajax({
            Headers: {
             'Accept': 'application/json',
             'Content-Type': 'application/json'
            },
            method: "POST",
            url: url,
            data: (data)
        });
    }
}