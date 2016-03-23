function GetNowElective() {
    
    
    $.when(
      $.ajax({
          //需要使用post提交
          type: "post",
          url: "/GetJson/GetNowElectiveCourseList_Json",
          async: true, //异步
          cache: false, //不加载缓存
          //dataType: "json",//对象为json
          success: function (e) {
              ajaxresult = e;

          },
          error: function (XMLHttpRequest, textStatus, errorThrown) {

              alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);

          }

      })).done(function () {
          if (ajaxresult.length != 0) {

              var EleCourseList = JSON.parse(ajaxresult);
              ViewModel =
              {
                  CouseList: ko.observableArray(EleCourseList)
              }
             

              //alert(ajaxresult);

              ko.applyBindings(ViewModel);
              $('#LoadingModal').modal('hide');

          }
      })
}
$(document).ready(function () {
    
    var ajaxresult = "";
    //获取后台课表
    var host = window.location.host.toUpperCase();
    var url = window.location.href.toUpperCase();
    var currentpage = url.replace(host, "").replace("HTTP://", "").replace("HTTPS://");

    if ((currentpage == "/Student/Main/".toUpperCase()) || (currentpage == "/Student/Main".toUpperCase())) {

        $.when(
        $.ajax({
            //需要使用post提交
            type: "post",
            url: "/GetJson/GetStudentNowKCBWithStuID_Json",
            async: true, //异步
            cache: false, //不加载缓存
            dataType: "json",//对象为json
            success: function (e) {
                $.each(e, function (j, item) {
                    for (i = 1; i <= 7; i++) {
                        if (item.Section == ((i * 2 - 1) + "-" + (i * 2) + "节")) {
                            //alert(item.StartWeek+"-"+item.EndWeek+"周");
                            var str = $("#" + item.Week + "_" + i).html() + " <br />" + item.CourseName + " <br /> " + item.TeacherName + "<br />" + item.StartWeek + "-" + item.EndWeek + "周" + item.SingleOrDouble + " <br />" + item.RoomName;
                            $("#" + item.Week + "_" + i).html(str);
                        }
                    }
                }
                    )

                //$('#message').html(e);
                //$('#myModal').modal({ backdrop: 'static', keyboard: true });

            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {

                alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);

            }

        })).done(function () { })

    } else if ((currentpage == "/Student/ChooseElectiveCourse/".toUpperCase()) || (currentpage == "/Student/ChooseElectiveCourse".toUpperCase()))
    {

        GetNowElective();

    }
})
