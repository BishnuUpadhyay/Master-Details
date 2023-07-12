/// <reference path="../knockoutjs.js" />



function CustomerModel(item) {

    var self = this;
    item = item || {};
    self.id = ko.observable(item.id || 0);
    self.customerName = ko.observable(item.customerName || '');
    self.address = ko.observable(item.address || '');
    self.phoneNumber = ko.observable(item.phoneNumber || '');
}
