
const ControllerName = {
    WareHouse: "Warehouse",
    Report: "Report"
}
function AddTabPanel(tabId, tabName, data) {
    var $tabPanelWrapper = $("#jsTabPanelWrapper");

    var tabPanelItem = $tabPanelWrapper.find("a[href='#" + tabId + "']");

    if (tabPanelItem.length)
        return;

    var tabPanelHtml = ` <li class="nav-item position-relative">
                            <a class="nav-link pr-4 active" data-toggle="tab" href="#${tabId}">
                                ${tabName}
                            </a>
                            <span class="mr-2 close-icon" onclick="RemoveTabPanel('${tabId}')" aria-hidden="true">&times;</span>
                        </li>`

    LoadTabContent(tabId, data);
    $tabPanelWrapper.find("a.nav-link").removeClass('active');
    $tabPanelWrapper.append(tabPanelHtml);
};

function RemoveTabPanel(tabId) {
    var tabPanelItem = $("#jsTabPanelWrapper").find("a[href='#" + tabId + "']");
    if (!tabPanelItem.length)
        return;

    tabPanelItem.closest('li').remove();
    $("#jsTabContent .tab-pane#" + tabId).empty();
};

function LoadTabContent(tabId, data) {
    var $tabContent = $("#jsTabContent");

    var tabContentUrl = '';
    switch (tabId) {
        case "warehouse1":
            tabContentUrl = `${ControllerName.WareHouse}/warehouse1`
            break;
        case "warehouse2":
            tabContentUrl = `${ControllerName.WareHouse}/warehouse2`
            break;
        case "warehouse3":
            tabContentUrl = `${ControllerName.WareHouse}/warehouse3`
            break
        case "report":
            tabContentUrl = `${ControllerName.Report}/Index?id=${data}`
            break;

    }


    var $tabPaneItem = $tabContent.find(".tab-pane#" + tabId)
    $tabContent.find(".tab-pane").removeClass('active');
    $tabPaneItem.addClass('active');

    $tabPaneItem.load(tabContentUrl, () => {
        $('.dataTable').DataTable();
    });
}