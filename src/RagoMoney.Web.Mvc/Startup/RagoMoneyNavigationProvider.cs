using Abp.Application.Navigation;
using Abp.Localization;
using RagoMoney.Authorization;

namespace RagoMoney.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class RagoMoneyNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Dashboard,
                        new FixedLocalizableString("Dashboard"),
                        url: "Dashboard",
                        icon: "home",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Tenants,
                        L("Tenants"),
                        url: "Tenants",
                        icon: "business",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Users,
                        L("Users"),
                        url: "Users",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Users
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Roles,
                        L("Roles"),
                        url: "Roles",
                        icon: "local_offer",
                        requiredPermissionName: PermissionNames.Pages_Roles
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.RetailersDetails,
                         new FixedLocalizableString("Retailers Details"),
                        url: "RetailersDetails",
                        icon: "people",
                        requiredPermissionName: PermissionNames.Pages_Distributor
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        "Transaction",
                        new FixedLocalizableString("Transaction"),
                        icon: "menu",
                        requiredPermissionName: PermissionNames.Pages_Distributor
                    )
            #region Transaction Sub Menu
                    .AddItem(
                        new MenuItemDefinition(
                            "Transaction",
                            new FixedLocalizableString("Transaction"),
                            icon: "menu",
                            requiredPermissionName: PermissionNames.Pages_Distributor
                        )
                        .AddItem(
                            new MenuItemDefinition(
                                  PageNames.MoneyTransfer,
                                 new FixedLocalizableString(PageNames.MoneyTransfer),
                                  icon: "money",
                                 requiredPermissionName: PermissionNames.Pages_Distributor
                                )
                            )
                        .AddItem(
                            new MenuItemDefinition(
                                "Option1",
                                new FixedLocalizableString("Option1"),
                                url: "#"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "Option2",
                                new FixedLocalizableString("Option2"),
                                url: "#"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "Option3",
                                new FixedLocalizableString("Option3"),
                                url: "#"
                            )
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "Option2",
                            new FixedLocalizableString("Option2"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "Option3",
                            new FixedLocalizableString("Option3"),
                            url: "#"
                        )
                    )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                        "ReportBalance",
                        new FixedLocalizableString("Report Balance"),
                        icon: "menu",
                        requiredPermissionName: PermissionNames.Pages_Distributor
                    )
            #region Report Balance Sub Menu
                    .AddItem(
                        new MenuItemDefinition(
                            "CashCollection",
                            new FixedLocalizableString("Cash Collection"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "LiveSale",
                            new FixedLocalizableString("Live Sale"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "MRPSale",
                            new FixedLocalizableString("MRP Sale"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "PendingPaymentRequest",
                            new FixedLocalizableString("Pending Payment Request"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "MarginRegister",
                            new FixedLocalizableString("Margin Register"),
                            url: "#"
                        )
                    )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                        "Invoice",
                        new FixedLocalizableString("Invoice"),
                        icon: "menu",
                        requiredPermissionName: PermissionNames.Pages_Distributor
                    )
            #region Invoice Sub Menu
                    .AddItem(
                        new MenuItemDefinition(
                            "CashSummary",
                            new FixedLocalizableString("Cash Summary"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "GSTInvoice",
                            new FixedLocalizableString("GST Invoice"),
                            url: "#"
                        )
                    )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                        "Accounts",
                        new FixedLocalizableString("Accounts"),
                        icon: "menu",
                        requiredPermissionName: PermissionNames.Pages_Distributor
                    )
            #region Accounts Sub Menu
                    .AddItem(
                        new MenuItemDefinition(
                            "MyLedger",
                            new FixedLocalizableString("My Ledger"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "RetailerLedger",
                            new FixedLocalizableString("Retailer Ledger"),
                            url: "#"
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "PaymentLedger",
                            new FixedLocalizableString("Payment Ledger"),
                            url: "#"
                        )
                    )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                            "Services",
                            new FixedLocalizableString("Services"),
                            icon: "apps",
                            requiredPermissionName: PermissionNames.Pages_Retailer
                    )
            #region Services Sub Menu
                            .AddItem(
                                new MenuItemDefinition(
                                    "Recharge",
                                    new FixedLocalizableString("Recharge"),
                                    url: "#"
                                )
                            )
                            .AddItem(
                                new MenuItemDefinition(
                                    "TravelServices",
                                    new FixedLocalizableString("Travel Services"),
                                    url: "#"
                                )
                            )
                            .AddItem(
                                new MenuItemDefinition(
                                    "MoneyRemittance",
                                    new FixedLocalizableString("Money Remittance"),
                                    url: "#"
                                )
                            )
                            .AddItem(
                                new MenuItemDefinition(
                                    "DigitalWallet",
                                    new FixedLocalizableString("Digital Wallet"),
                                    url: "#"
                                )
                            )
                            .AddItem(
                                new MenuItemDefinition(
                                    "PayWorldBazaar",
                                    new FixedLocalizableString("PayWorld Bazaar"),
                                    url: "#"
                                )
                            )
                            .AddItem(
                                new MenuItemDefinition(
                                    "Insurance",
                                    new FixedLocalizableString("Insurance"),
                                    url: "#"
                                )
                            )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                            "Payments",
                            new FixedLocalizableString("Payments"),
                            icon: "attach_money",
                            requiredPermissionName: PermissionNames.Pages_Retailer
                    )
            #region Payments Sub Menu
                    .AddItem(
                        new MenuItemDefinition(
                            "OnlinePayment",
                            new FixedLocalizableString("Online Payment"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "PaymentRequest",
                            new FixedLocalizableString("Payment Request"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "ICICIPaysure",
                            new FixedLocalizableString("ICICI Paysure"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "RefillPoint",
                            new FixedLocalizableString("Refill Point"),
                            url: "#"
                        )
                    )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                            "Reports",
                            new FixedLocalizableString("Reports"),
                            icon: "poll",
                            requiredPermissionName: PermissionNames.Pages_Retailer
                    )
            #region Reports Sub Menus
                      .AddItem(
                        new MenuItemDefinition(
                            "PartyLedger",
                            new FixedLocalizableString("Party Ledger"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "BundleInsuranceReport",
                            new FixedLocalizableString("Bundle Insurance Report"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "SummarizedLedger",
                            new FixedLocalizableString("Summarized Ledger"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "GSTInvoice",
                            new FixedLocalizableString("GST Invoice"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "SalesReport",
                            new FixedLocalizableString("Sales Report"),
                            url: "#"
                        )
                    )
                    .AddItem(
                        new MenuItemDefinition(
                            "TransactionsReport",
                            new FixedLocalizableString("Transactions Report"),
                            url: "#"
                        )
                    )
            #endregion
                ).AddItem(
                    new MenuItemDefinition(
                            "ControlPanel",
                            new FixedLocalizableString("Control Panel"),
                            icon: "settings",
                            requiredPermissionName: PermissionNames.Pages_Retailer
                    )
            #region Control Panel Sub Menu
                    .AddItem(
                        new MenuItemDefinition(
                            "ResetTransactionPassword",
                            new FixedLocalizableString("Reset Transaction Password"),
                            url: "#"
                        )
                    )
            #endregion
                )
                


                ;
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, RagoMoneyConsts.LocalizationSourceName);
        }
    }
}
