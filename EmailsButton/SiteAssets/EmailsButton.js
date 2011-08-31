/// <reference name="MicrosoftAjax.js" /> 
/// <reference path="file://C:/Program Files/Common Files/Microsoft Shared/Web Server Extensions/14/TEMPLATE/LAYOUTS/SP.core.debug.js" />
/// <reference path="file://C:/Program Files/Common Files/Microsoft Shared/Web Server Extensions/14/TEMPLATE/LAYOUTS/SP.debug.js" />
/// <reference path="file://C:/Program Files/Common Files/Microsoft Shared/Web Server Extensions/14/TEMPLATE/LAYOUTS/SP.UI.Dialog.debug.js" />
/// <reference path="SiteAssets/CamlBuilder.js" />

function PopupEmailsDialog() {
    var context = new SP.ClientContext.get_current();
    var web = context.get_web();
    var list = web.get_lists().getById(SP.ListOperation.Selection.getSelectedList());
    
    var items = SP.ListOperation.Selection.getSelectedItems();
    var itemIds = new Array();
    for (var i = 0; i < items.length; i++) {
        itemIds.push(items[i].id);
    }

    var query = new SP.CamlQuery();
    var camlBuilder = new CamlBuilder();
    var caml = camlBuilder.IntegerField("ID").In(itemIds).ToString();
    query.set_viewXml("<View><Query><Where>" + caml + "</Where></Query></View>");
    var items = list.getItems(query, 'Include(Email)');
    context.load(items);

    context.executeQueryAsync(
        function (sender, args) {
            var enumerator = items.getEnumerator();
            var emails = new Array();
            while (enumerator.moveNext()) {
                var item = enumerator.get_current();
                emails.push(item.get_item('Email'));
            }

            var div = document.createElement('div');
            div.innerHTML = emails.join('<br />');
            var options =
            {
                html: div,
                title: "Emails button test"
            };

            SP.UI.ModalDialog.showModalDialog(options);
        },
        function (sender, args) {
            alert("Error! " + args.Message + "\nStack trace: " + args.StackTrace);
        }
        );
}