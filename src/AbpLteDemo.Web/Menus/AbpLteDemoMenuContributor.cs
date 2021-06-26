using System.Threading.Tasks;
using AbpLteDemo.Localization;
using AbpLteDemo.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace AbpLteDemo.Web.Menus
{
    public class AbpLteDemoMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var administration = context.Menu.GetAdministration();
            var l = context.GetLocalizer<AbpLteDemoResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    AbpLteDemoMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                )
            );

            context.Menu.AddItem(new ApplicationMenuItem("Dashboard", "Dashboard", icon: "fas fa-tachometer-alt", order: 1)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.Dashboard1,
                    displayName: "Dashboard1",
                    url: "~/Dashboard",
                    icon: "far fa-circle",
                    order: 2
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.Dashboard2,
                    displayName: "Dashboard2",
                    url: "~/Dashboard2",
                    icon: "far fa-circle",
                    order: 3
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.Dashboard3,
                    displayName: "Dashboard3",
                    url: "~/Dashboard3",
                    icon: "far fa-circle",
                    order: 4
                    ))
                );

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    AbpLteDemoMenus.Widgets,
                    "Widgets",
                    "~/Widgets",
                    icon: "fas fa-th",
                    order: 5
                )
            );

            context.Menu.AddItem(new ApplicationMenuItem("Charts", "Charts", icon: "fas fa-chart-pie", order: 6)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ChartsChartJS,
                    displayName: "ChartJS",
                    url: "~/ChartsChartjs",
                    icon: "far fa-circle",
                    order: 7
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ChartsFlot,
                    displayName: "Flot",
                    url: "~/ChartsFlot",
                    icon: "far fa-circle",
                    order: 8
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ChartsInline,
                    displayName: "Inline",
                    url: "~/ChartsInline",
                    icon: "far fa-circle",
                    order: 9
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ChartsUplot,
                    displayName: "uPlot",
                    url: "~/ChartsUplot",
                    icon: "far fa-circle",
                    order: 10
                    ))
                );

            context.Menu.AddItem(new ApplicationMenuItem("UI Elements", "UI Elements", icon: "fas fa-tree", order: 11)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementGeneral,
                    displayName: "General",
                    url: "~/ElementGeneral",
                    icon: "far fa-circle",
                    order: 12
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementIcons,
                    displayName: "Icons",
                    url: "~/ElementIcons",
                    icon: "far fa-circle",
                    order: 13
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementButtons,
                    displayName: "Buttons",
                    url: "~/ElementButtons",
                    icon: "far fa-circle",
                    order: 14
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementSliders,
                    displayName: "Sliders",
                    url: "~/ElementSliders",
                    icon: "far fa-circle",
                    order: 15
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementModals,
                    displayName: "Modals & Alerts",
                    url: "~/ElementModals",
                    icon: "far fa-circle",
                    order: 16
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementNavbar,
                    displayName: "Navbar & Tabs",
                    url: "~/ElementNavbar",
                    icon: "far fa-circle",
                    order: 17
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementTimeline,
                    displayName: "Timeline",
                    url: "~/ElementTimeline",
                    icon: "far fa-circle",
                    order: 18
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ElementRibbons,
                    displayName: "Ribbons",
                    url: "~/ElementRibbons",
                    icon: "far fa-circle",
                    order: 19
                    ))
                );

            context.Menu.AddItem(new ApplicationMenuItem("Forms", "Forms", icon: "fas fa-edit", order: 20)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.FormGeneral,
                    displayName: "General Elements",
                    url: "~/FormGeneral",
                    icon: "far fa-circle",
                    order: 21
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.FormAdvanced,
                    displayName: "Advanced Elements",
                    url: "~/FormAdvanced",
                    icon: "far fa-circle",
                    order: 22
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.FormEditor,
                    displayName: "Editors",
                    url: "~/FormEditor",
                    icon: "far fa-circle",
                    order: 23
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.FormValidation,
                    displayName: "Validation",
                    url: "~/FormValidation",
                    icon: "far fa-circle",
                    order: 24
                    ))
                );

            context.Menu.AddItem(new ApplicationMenuItem("Tables", "Tables", icon: "fas fas fa-table", order: 25)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.TableSimple,
                    displayName: "Simple Tables",
                    url: "~/TableSimple",
                    icon: "far fa-circle",
                    order: 26
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.TableData,
                    displayName: "Data Tables",
                    url: "~/TableData",
                    icon: "far fa-circle",
                    order: 27
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.TableGrid,
                    displayName: "jsGrid",
                    url: "~/TableGrid",
                    icon: "far fa-circle",
                    order: 28
                    ))
                );

            context.Menu.Items.Insert(
               0,
               new ApplicationMenuItem(
                   AbpLteDemoMenus.Calendar,
                   "Calendar",
                   "~/Calendar",
                   icon: "far fa-calendar-alt",
                   order: 29
               )
           );

            context.Menu.Items.Insert(
               0,
               new ApplicationMenuItem(
                   AbpLteDemoMenus.Gallery,
                   "Gallery",
                   "~/Gallery",
                   icon: "far fa-image",
                   order: 30
               )
           );

            context.Menu.Items.Insert(
               0,
               new ApplicationMenuItem(
                   AbpLteDemoMenus.Kanban,
                   "Kanban Board",
                   "~/Kanban",
                   icon: "fas fa-columns",
                   order: 31
               )
           );

            context.Menu.AddItem(new ApplicationMenuItem("Mailbox", "Mailbox", icon: "far fa-envelope", order: 32)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.MailInbox,
                    displayName: "Inbox",
                    url: "~/MailInbox",
                    icon: "far fa-circle",
                    order: 33
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.MailCompose,
                    displayName: "Compose",
                    url: "~/MailCompose",
                    icon: "far fa-circle",
                    order: 34
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.MailRead,
                    displayName: "Read",
                    url: "~/MailRead",
                    icon: "far fa-circle",
                    order: 35
                    ))
                );

            context.Menu.AddItem(new ApplicationMenuItem("Pages", "Pages", icon: "fas fa-book", order: 36)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesInvoice,
                    displayName: "Invoice",
                    url: "~/PagesInvoice",
                    icon: "far fa-circle",
                    order: 37
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesProfile,
                    displayName: "Profile",
                    url: "~/PagesProfile",
                    icon: "far fa-circle",
                    order: 38
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesEcommerce,
                    displayName: "E-commerce",
                    url: "~/PagesEcommerce",
                    icon: "far fa-circle",
                    order: 39
                    )).AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesProjects,
                    displayName: "Projects",
                    url: "~/PagesProjects",
                    icon: "far fa-circle",
                    order: 40
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesProjectAdd,
                    displayName: "Project Add",
                    url: "~/PagesProjectAdd",
                    icon: "far fa-circle",
                    order: 41
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesProjectEdit,
                    displayName: "Project Edit",
                    url: "~/PagesProjectEdit",
                    icon: "far fa-circle",
                    order: 42
                    )).AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesProjectDetail,
                    displayName: "Project Detail",
                    url: "~/PagesProjectDetail",
                    icon: "far fa-circle",
                    order: 43
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesContacts,
                    displayName: "Contacts",
                    url: "~/PagesContacts",
                    icon: "far fa-circle",
                    order: 44
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesFaq,
                    displayName: "FAQ",
                    url: "~/PagesFaq",
                    icon: "far fa-circle",
                    order: 45
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.PagesContactUs,
                    displayName: "Contact Us",
                    url: "~/PagesContactUs",
                    icon: "far fa-circle",
                    order: 47
                    ))
                );

            context.Menu.AddItem(new ApplicationMenuItem("Extras", "Extras", icon: "far fa-plus-square", order: 48)
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ExtraLogin,
                    displayName: "Login",
                    url: "~/ExtraLogin",
                    icon: "far fa-circle",
                    target: "_blank",
                    order: 49
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ExtraRegister,
                    displayName: "Register",
                    url: "~/ExtraRegister",
                    icon: "far fa-circle",
                    target: "_blank",
                    order: 50
                    ))
                .AddItem(new ApplicationMenuItem(
                    name: AbpLteDemoMenus.ExtraForgotpassword,
                    displayName: "Forgot Password",
                    url: "~/ExtraForgotpassword",
                    icon: "far fa-circle",
                    target: "_blank",
                    order: 51
                    ))
                );

            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 100);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 100);
            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 200);

            await Task.Yield();
        }
    }
}
