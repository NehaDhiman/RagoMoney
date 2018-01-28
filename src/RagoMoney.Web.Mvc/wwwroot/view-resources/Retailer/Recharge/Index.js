(function () {
    $(function () {

        var _$page = $('#rechargePage');

        // Mobile Recharge
        var _$mobileRechargeForm = _$page.fine$('form[name="MobileRecharge"]');
        _$mobileRechargeForm.validate({
            rules: {
                MobileNumber: {
                    required: true
                },
                Operator: {
                    required: true
                },
                Circle: {
                    required: true
                },
                Amount: {
                    rquired: true
                }
            },

            highlight: function (input) {
                $(input).parents('.form-line').addClass('error');
            },

            unhighlight: function (input) {
                $(input).parents('.form-line').removeClass('error');
            },

            errorPlacement: function (error, element) {
                $(element).parents('.form-group').append(error);
            }
        });

        _$mobileRechargeForm.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$mobileRechargeForm.valid()) {
                return;
            }

            var _model = _$mobileRechargeForm.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$mobileRechargeForm);
            _rechargeService.mobileRecharge(_model).done(function () {
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$mobileRechargeForm);
            });
        });

        // Mobile Bill Payment
        var _$mobileBillPaymentForm = _$page.fine$('form[name="MobileBillPayment"]');
        _$mobileBillPaymentForm.validate({
            rules: {
                MobileNumber: {
                    required: true
                },
                Operator: {
                    required: true
                },
                Circle: {
                    required: true
                },
                Amount: {
                    rquired: true
                }
            },

            highlight: function (input) {
                $(input).parents('.form-line').addClass('error');
            },

            unhighlight: function (input) {
                $(input).parents('.form-line').removeClass('error');
            },

            errorPlacement: function (error, element) {
                $(element).parents('.form-group').append(error);
            }
        });

        _$mobileBillPaymentForm.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$mobileBillPaymentForm.valid()) {
                return;
            }

            var _model = _$mobileBillPaymentForm.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$mobileBillPaymentForm);
            _rechargeService.mobileBillPayment(_model).done(function () {
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$mobileBillPaymentForm);
            });
        });

        // DTH Recharge
        var _$dthRechargeForm = _$page.fine$('form[name="DTHRecharge"]');
        _$dthRechargeForm.validate({
            rules: {
                Operator: {
                    required: true
                },
                CustomerId: {
                    required: true
                },
                CustomerMobilerNo: {
                    required: true
                },
                Amount: {
                    rquired: true
                }
            },

            highlight: function (input) {
                $(input).parents('.form-line').addClass('error');
            },

            unhighlight: function (input) {
                $(input).parents('.form-line').removeClass('error');
            },

            errorPlacement: function (error, element) {
                $(element).parents('.form-group').append(error);
            }
        });

        _$dthRechargeForm.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$dthRechargeForm.valid()) {
                return;
            }

            var _model = _$dthRechargeForm.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$dthRechargeForm);
            _rechargeService.dthRecharge(_model).done(function () {
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$dthRechargeForm);
            });
        });

        // Data Card Recharge
        var _$datacardForm = _$page.fine$('form[name="DatacardRecharge"]');
        _$datacardForm.validate({
            rules: {
                MobileNumber: {
                    required: true
                },
                Operator: {
                    required: true
                },
                Circle: {
                    required: true
                },
                Amount: {
                    rquired: true
                }
            },

            highlight: function (input) {
                $(input).parents('.form-line').addClass('error');
            },

            unhighlight: function (input) {
                $(input).parents('.form-line').removeClass('error');
            },

            errorPlacement: function (error, element) {
                $(element).parents('.form-group').append(error);
            }
        });

        _$datacardForm.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$datacardForm.valid()) {
                return;
            }

            var _model = _$datacardForm.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$datacardForm);
            _rechargeService.dthRecharge(_model).done(function () {
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$datacardForm);
            });
        });
    });
})();