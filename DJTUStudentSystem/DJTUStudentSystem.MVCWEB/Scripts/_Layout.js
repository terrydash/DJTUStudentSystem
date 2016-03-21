var w;
$(function () { $('#myModal').modal('hide') });

$(function () {
    $('#myModal').on('hide.bs.modal', function () {


        if (w == "选课成功！请返回首页查看课表！" || w == "退选成功！") {
            $(':button').attr("disabled", true);

            $('#message').html("页面刷新中！请不要连续刷新!");
            $('#myModal').modal({ backdrop: 'static', keyboard: true });


            location.reload();

        }

    })
});
function ChooseCourse(tcid) {

    var data = "tcid=" + tcid;
    $(':button').attr("disabled", true);
    $.ajax({
        //需要使用post提交
        type: "post",
        url: "/Student/ChooseCourse",
        data: data,
        async: true, //异步
        cache: false, //不加载缓存
        //dataType: "json",//对象为json
        success: function (e) {
            w = e;

            $(':button').attr("disabled", false);
            $('#message').html(e);
            $('#myModal').modal({ backdrop: 'static', keyboard: true });

        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

            alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);
            $(':button').attr("disabled", false);

        }

    });

}

function DeleteCourse(srid) {
    if (confirm("确定退选吗?")) {


        var data = "srid=" + srid;
        $(':button').attr("disabled", true);
        $.ajax({
            //需要使用post提交
            type: "post",
            url: "/Student/DeleteCourse",
            data: data,
            async: true, //异步
            cache: false, //不加载缓存
            //dataType: "json",//对象为json
            success: function (e) {
                w = e;
                $(':button').attr("disabled", false);
                $('#message').html(e);
                $('#myModal').modal({ backdrop: 'static', keyboard: true });

            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {

                alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);
                $(':button').attr("disabled", false);
            }

        });
    }
}
$(document).ready(function () {
    $('#message').html("<h1>当前系统为测试阶段，所选课程只为测试，选课视为无效，正式选课前将清空名单！</h1>");
    $('#myModal').modal({ backdrop: 'static', keyboard: true });
    $('#sample-table-2').DataTable({
        "bSort": true, "language": {
            "sProcessing": "处理中...",
            "sLengthMenu": "显示 _MENU_ 项结果",
            "sZeroRecords": "没有匹配结果",
            "sInfo": "显示第 _START_ 至 _END_ 项结果，共 _TOTAL_ 项",
            "sInfoEmpty": "显示第 0 至 0 项结果，共 0 项",
            "sInfoFiltered": "(由 _MAX_ 项结果过滤)",
            "sInfoPostFix": "",
            "sSearch": "搜索:",
            "sUrl": "",
            "sEmptyTable": "表中数据为空",
            "sLoadingRecords": "载入中...",
            "sInfoThousands": ",",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上页",
                "sNext": "下页",
                "sLast": "末页"
            },
            "oAria": {
                "sSortAscending": ": 以升序排列此列",
                "sSortDescending": ": 以降序排列此列"
            }
        }
    })
});
$(document).ready(function () {

    $('#Elective').DataTable({
        "bSort": true, "language": {
            "sProcessing": "处理中...",
            "sLengthMenu": "显示 _MENU_ 项结果",
            "sZeroRecords": "没有匹配结果",
            "sInfo": "显示第 _START_ 至 _END_ 项结果，共 _TOTAL_ 项",
            "sInfoEmpty": "显示第 0 至 0 项结果，共 0 项",
            "sInfoFiltered": "(由 _MAX_ 项结果过滤)",
            "sInfoPostFix": "",
            "sSearch": "搜索:",
            "sUrl": "",
            "sEmptyTable": "表中数据为空",
            "sLoadingRecords": "载入中...",
            "sInfoThousands": ",",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上页",
                "sNext": "下页",
                "sLast": "末页"
            },
            "oAria": {
                "sSortAscending": ": 以升序排列此列",
                "sSortDescending": ": 以降序排列此列"
            }
        }
    })
});
