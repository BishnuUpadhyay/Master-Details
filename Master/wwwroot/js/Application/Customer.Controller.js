/// <reference path="../knockoutjs.js" />



function CustomerController() {
    var self = this;

    const baseUrl = "/api/CustomersApi";
    self.newCustomer = new CustomerModel();
    self.customers = ko.observableArray([]);

    ajax.get(baseUrl).then(function (result) {
        var datas = ko.utils.arrayMap(result, function (item) {
            return new CustomerModel(item);
        });
        self.customers(datas);
    });

    self.addCustomer = function () {  
        console.log(ko.toJSON(self.newCustomer));
        ajax.post(baseUrl, ko.toJSON(self.newCustomer))
            .done(function (result) {
                alert();
                self.customers.push(new CustomerModel(result));
                self.newCustomer = new CustomerModel();
            });
    }
}
    var ajax = {
        get: function (url, data) {
            return $.ajax({
                method: "GET",
                url: url
            });
        },
        post: function (url, data) {
            return $.ajax({
                method: "POST",
                url: url,
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                data: data
            });
        }
    }