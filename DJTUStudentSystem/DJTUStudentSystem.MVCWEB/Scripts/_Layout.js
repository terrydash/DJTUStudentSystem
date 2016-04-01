
/*
全局JS：

*/
var ViewModel = new function ()
{
    this.CourseList = ko.observableArray();    
    this.Student = ko.observable();
    this.HowManyNowHaveStudentChoose = ko.observable();
    this.StudentName = ko.observable();
    this.GradeName = ko.observable();
    this.GradeCanChoose=ko.observable();
    this.HowManyHaveStudentChoose = ko.observable();
    
}



var ajaxresult = "";
var IsAjaxing = false;
var IsBind = false;


//选课的AJAX
function ChooseCourse(tcid) {
    if (IsAjaxing) {
        return false;
    }
    var data = "tcid=" + tcid;
    $(':button').attr("disabled", true);
    IsAjaxing = true;
    $.ajax({
        //需要使用post提交
        type: "post",
        url: "/Student/ChooseCourse",
        data: data,
        async: true, //异步
        cache: false, //不加载缓存
        //dataType: "json",//对象为json
        success: function (e) {
            
            IsAjaxing = false;
            $('#message').html(e);
            $('#myModal').modal({ backdrop: 'static', keyboard: true });
            $(':button').attr("disabled", false)
            if (e = "选课成功！请返回首页查看课表！")
             {
                   $.when(GetStudentinfo())
                   .done(GetNowElective())
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            IsAjaxing = false;
            alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);
            $(':button').attr("disabled", false);

        }

    });

}

function DeleteCourse(srid) {
   
   
    if (confirm("确定退选吗?")) {
      

        var data = "srid=" + srid;
        $(':button').attr("disabled", true);
        if (IsAjaxing) {
            return false;
        }


        IsAjaxing = true;
        $.ajax({
            //需要使用post提交
            type: "post",
            url: "/Student/DeleteCourse",
            data: data,
            async: true, //异步
            cache: false, //不加载缓存
            //dataType: "json",//对象为json
            success: function (e) {
                IsAjaxing = false;
                $(':button').attr("disabled", false)
                $('#message').html(e);
                $('#myModal').modal({ backdrop: 'static', keyboard: true });
                if (e == "退选成功！")
                {
                 $.when(GetStudentinfo())
                .done( GetNowElective())
                }
                



            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                IsAjaxing = false;
                alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);
                $(':button').attr("disabled", false);
            }

        });
    }
}
function GetNowElective() {

    
    if (IsAjaxing)
    {
        return false;
    }
    $("#Elective").showLoading();
    IsAjaxing = true;
    $.when(
      $.ajax({
          //需要使用post提交
          type: "post",
          url: "/GetJson/GetNowElectiveCourseList_Json",
          async: true, //异步
          cache: false, //不加载缓存
          //dataType: "json",//对象为json
          success: function (e) {
              IsAjaxing = false;
              if (e == "tofast".toUpperCase()) {
                  return false;
              }
              ajaxresult = e;
              
          },
          error: function (XMLHttpRequest, textStatus, errorThrown) {
              IsAjaxing = false;
              alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);

          }

      })).done(function () {
          $("#Elective").hideLoading();
          
          if (ajaxresult.length != 0) {
              
              /*
              $('#message').html(ajaxresult);
              $('#myModal').modal({ backdrop: 'static', keyboard: true });
              */
              var num = ViewModel.CourseList().length

              if (num > 0) {
                  for (var i = 0; i < num; i++) {
                      ViewModel.CourseList.pop();
                  }

              }
              ko.utils.arrayForEach(JSON.parse(ajaxresult), function (item) {

                  ViewModel.CourseList.push(item);

              });
              MakeTablePager("Elective");
              return false;
         
            
              
          }
      })
}
function GetStudentinfo() {
    if (IsAjaxing) {
        return false;
    }
    $("#pagecontent").showLoading();
    IsAjaxing = true;
    $.when(
          $.ajax({
              //需要使用post提交
              type: "post",
              url: "/GetJson/GetStudentInfoFromSession_Json",
              async: true, //异步
              cache: false, //不加载缓存
              //dataType: "json",//对象为json
              success: function (e) {
                  IsAjaxing = false;
                  if (e == "tofast".toUpperCase() ) {
                     
                      return false;
                  }
                  ajaxresult = e;

                  $("#pagecontent").hideLoading();
              },
              error: function (XMLHttpRequest, textStatus, errorThrown) {
                  IsAjaxing = false;
                  alert("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);

              }

          })).done(function () {

              if (ajaxresult.length != 0) {


                  var Studentinfo = JSON.parse(ajaxresult);
                  ViewModel.Student = Studentinfo;
                  var NowStuReportViewModelList = Studentinfo.NowStuReportViewModelList;
                  var StudentKCBViewModelList = Studentinfo.StudentKCBViewModelList;
                  //alert(ViewModel.Student.GradeCanChoose);
                  //alert(NowStuReportViewModelList.length);
                
                  
                  /*
                  $('#message').html(ajaxresult);
                  $('#myModal').modal({ backdrop: 'static', keyboard: true });
                  */
                  var host = window.location.host.toUpperCase();
                  var url = window.location.href.toUpperCase();
                  var currentpage = url.replace(host, "").replace("HTTP://", "").replace("HTTPS://");


                  if ((currentpage == "/Student/Main/".toUpperCase()) || (currentpage == "/Student/Main".toUpperCase())) {

                      $.each(StudentKCBViewModelList, function (j, item) {
                          for (i = 1; i <= 7; i++) {
                              if (item.Section == ((i * 2 - 1) + "-" + (i * 2) + "节")) {

                                  var str = $("#" + item.Week + "_" + i).html() + " <br />" + item.CourseName + " <br /> " + item.TeacherName + "<br />" + item.StartWeek + "-" + item.EndWeek + "周" + item.SingleOrDouble + " <br />" + item.RoomName;
                                  $("#" + item.Week + "_" + i).html(str);
                              }
                          }
                      }
                )


                  } else if ((currentpage == "/Student/ChooseElectiveCourse/".toUpperCase()) || (currentpage == "/Student/ChooseElectiveCourse".toUpperCase())) {
                      //alert(Studentinfo.HowManyNowHaveStudentChoose);
                      //alert(ViewModel.Student.HowManyNowHaveStudentChoose);
                      
                      ViewModel.GradeCanChoose(Studentinfo.GradeCanChoose);
                      ViewModel.GradeName (Studentinfo.GradeName);
                      ViewModel.HowManyHaveStudentChoose (Studentinfo.HowManyHaveStudentChoose);
                      ViewModel.StudentName (Studentinfo.StudentName);
                      ViewModel.HowManyNowHaveStudentChoose(Studentinfo.HowManyNowHaveStudentChoose);
                      //alert(Studentinfo.HowManyNowHaveStudentChoose);
                      
                      GetNowElective();
                     
                  }
                  if (!IsBind)
                  {
                      ko.applyBindings(ViewModel);
                      IsBind = true;
                  }
                  
                  return false;


              }
          })

}
$(document).ready(function () {
    //$('#message').html("<h3>公选课目前只开放了总人数的80%,其余20%和14级剩余容量将在第二轮本周五（2016年4月1日）16:00准时开放，未选上的同学可以再次选择。</h3>");
    //$('#myModal').modal({ backdrop: 'static', keyboard: true });
    
    GetStudentinfo();
      
    
    

    

      

  
    
}
);

   

    


    /*
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
    */
