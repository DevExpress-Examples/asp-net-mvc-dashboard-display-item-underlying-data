@Code
    ViewBag.Title = "MVCxDashboard"
End Code

@section Scripts
    <script src="~/Scripts/UnderlyingData.js"></script>
End section

<div id="detailGrid" style="position:absolute; left:800px; right:0; top:0; bottom:0;"></div>
<div style="position:absolute; left:0; right:0; top:0; bottom:0;">
    @Html.DevExpress().Dashboard(Sub(settings)
        settings.Name = "Dashboard"
        settings.Width = Unit.Pixel(800)
        settings.Height = Unit.Pixel(800)
        settings.ControllerName = "DefaultDashboard"
        settings.WorkingMode = DevExpress.DashboardWeb.WorkingMode.Viewer
        settings.ClientSideEvents.BeforeRender = "onBeforeRender"
    End Sub).GetHtml()
</div>