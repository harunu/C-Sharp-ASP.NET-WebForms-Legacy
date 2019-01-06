<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AsisBayi.Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
    <title></title>
    <link type="text/css" href="css/custom-theme/jquery-ui-1.8.17.custom.css" rel="stylesheet" />
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-1.8.17.custom.min.js"></script>
    <script type="text/javascript" src="http://jzaefferer.github.com/jquery-validation/jquery.validate.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.edit').click(function () {
                alert($(this).parents('tr:first').attr('parentId'));
                alert($(this).parents('tr:first').attr('childId'));

                var parentId;
                parentId = $(this).parents('tr:first').attr('parentId');
                var childId;
                childId = $(this).parents('tr:first').attr('childId');
                $.ajax({
                    type: "POST",
                    url: "default.aspx",
                    data: "action=list&parentId=" + parentId + "&childId=" + childId,
                    success: function (txt) {
                        if (txt.indexOf('var harun =') == 0) {
                            eval(txt);
                            $('#txtAciklama').val(harun['Text']);
                            $('#txtTelefon').val(harun['Telefon']);
                            $('#txtFaks').val(harun['Faks']);
                            $('#txtSorumlu').val(harun['Sorumlu']);
                            $('#txtAdres').val(harun['Adres']);
                            $('#txtParentId').val(harun['parentId']);
                            $('#txtChildId').val(harun['childId']);

                        }
                    }
                });
                openDialog();
                return false;
            });
            $('.delete').click(function () {
                alert('silme');
                return false;
            //})
        });
        function closeDialog() {
            //Could cause an infinite loop because of "on close handling"
            $("#divEditCustomer").dialog('close');
        }
        function openDialog() {
            $("#divEditCustomer").dialog({
                title: "Bayi Bilgi Düzenleme",
                modal: true,
                resizeable: false,
                width: '500px',
                buttons: {
                    "Düzenle": function () {
                        var parentId;
                        parentId = $(this).parents('tr:first').attr('parentId');
                        var childId;
                        childId = $(this).parents('tr:first').attr('childId');
                        var senddata = {
                            ntxtAciklama: $('#txtAciklama').val(),
                            ntxtTelefon: $('#txtTelefon').val(),
                            ntxtFaks: $('#txtFaks').val(),
                            ntxtSorumlu: $('#txtSorumlu').val(),
                            ntxtAdres: $('#txtAdres').val(),
                         // parentId:$(this).parents('tr:first').attr('parentId'),
                            ntxtParentId: $('#txtParentId').val(),
                            ntxtChildId: $('#txtChildId').val()
                        //childId: $(this).parents('tr:first').attr('childId')

                        };
                        $.post('default.aspx', senddata,
            function (data) {
                alert('Hello');
                // alert(data.ntxtAciklama);
                // console.log(data.ntxtTelefon);
            }, 'json');


                    },

                    "İptal": function () {
                        $(this).dialog("close");

                    }
                }
            });
        }
	
    </script>
    </head>

<body>
    <form id="form1" runat="server">
        <div id="divEditCustomer" title="Değiştir" style="display: none">
        <div>
            Değiştirmek istediğiniz özellikleri yazın.<br />
            <br />
            <br />
            <table style="width: 100%; margin-right: 0px;">
                <tr>
                    <td class="style7" style="padding-left: 20px">
                        Açıklama:
                    </td>
                    <td>
                        <input id="txtAciklama" type="text" maxlength="128" class="edit" />
                    </td>
                </tr>
                <tr>
                    <td class="style7" style="padding-left: 20px">
                        Telefon:
                    </td>
                    <td class="style8">
                        <input id="txtTelefon" type="text" value="" class="required NumbersOnly" />
                    </td>
                </tr>
                <tr>
                    <td class="style7" style="padding-left: 20px">
                        Faks:
                    </td>
                    <td class="style8">
                        <input id="txtFaks" type="text" />
                    </td>
                </tr>
                <tr>
                    <td class="style7" style="padding-left: 20px">
                        Sorumlu:
                    </td>
                    <td class="style8">
                        <input id="txtSorumlu" type="text" />
                    </td>
                </tr>
                <tr>
                    <td class="style7" style="padding-left: 20px">
                        Adres:
                    </td>
                    <td class="style8">
                         <textarea id="txtAdres" name="S1" rows="2" cols="30"></textarea>
                        <div id = "txtParentId" >     
                        </div>
                          <div id = "txtChildId" >     
                        </div>

                    </td>
                </tr>
            </table>
         <br />
        </div>
    </div>
    </form>
</body>
</html>
