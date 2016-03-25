/*
表格分页 需要jquery+bootstrap
*/

var _tableid = "";//表格ID
var pageSize = 5;//每页显示的记录条数
var currentPage = 1;//当前页
var pagenums = 1;//总共页数
var trnums=0;//总共的行数
function dispalyTable(page) {
   
   
    
    $("#"+_tableid +" tbody tr").show();
    $("#"+_tableid + " tbody tr:lt(" + ((pageSize * (page - 1))) + ")").hide();
    $("#" + _tableid + " tbody tr:gt(" + ((pageSize * page) - 1) + ")").hide();
    currentPage = page;
    $("#" + _tableid + "tips").html("页码:" + currentPage + "/" + pagenums+" 共"+trnums+"项" );    
}
function MakeTablePager(TableID) {
    _tableid= ""+ TableID;
    var _table = $('#' + _tableid);
    $('#' + _tableid + "  tfoot").empty();
    var _tabletr = $('#' + _tableid + " tbody tr");
    var _tableheadtr = $('#' + _tableid + " thead tr");
     trnums = _tabletr.length;
    var lastPage;
    var direct = 0;
    var pagebutton = "";
    $(document).ready(function () {
        var _columnnums = $('#' + TableID + " thead tr").find("th").length;
        //alert("_columnnums=" + _columnnums);
        pagenums = Math.ceil(trnums / pageSize);
        for (var i = 1; i <=pagenums; i++) {
            pagebutton = pagebutton + "<li style='cursor: pointer;'><a onclick='dispalyTable(" + i + ");'>" + i + "</a></li>";

        }
        _table.append("<tfoot><tr ><td  colspan='" + _columnnums + "' ><ul  class='pagination' ><li ><span id='" + TableID + "tips' class='text-danger'></span></li><li><a href='#'>&laquo;</a></li>" + pagebutton + " <li><a href='#'>&raquo;</a></li></ul></td></tr></tfoot>");
        
        dispalyTable(currentPage);
       
       
       

    }
);
}