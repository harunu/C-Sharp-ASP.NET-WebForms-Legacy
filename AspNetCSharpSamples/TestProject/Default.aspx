<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="TestProject._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

<style type="text/css">

 *{height:100%}

.sagust
{
    
width:200px;
height:200px;
top:0px;
right:0px;
position:absolute;
background:#F40B16;} 
.sagalt{
width:400px;
height:400px;
bottom:0px;
right:0px;
position:absolute;
background:#0BF410;
}
</style>

<script type="text/javascript" src="Scripts/jquery-1.4.1.min.js"></script>
<script type="text/javascript">

    $(document).ready(function () {
        $('DIV.sagalt').bind('mouseover', function () { pos($(this)); });
        $('DIV.sagust').bind('mouseover', function () { pos($(this)); });

    });
    function pixel() {
        var container = document.getElementById("sagust");
        var message = "The height is" + sagust.clientHeight + "px.\n";
        message += "The width is " + sagust.clientWidth + "px.\n";
        alert(message);
    }
    function pos(obj) {
        var ofs = obj.offset();
        document.title = obj.html()+(ofs.top + ' ' + ofs.left);
    }
    </script>
    <title> </title>
</head>
<body style="margin-bottom: 0px;height:100%;position:relative;">
<div class="sagust"> Sağ üst</div>
<div class="sagalt" >Sağ alt
<div class="sagust" >Sağ üst</div>
</div>
</body>
</html>
