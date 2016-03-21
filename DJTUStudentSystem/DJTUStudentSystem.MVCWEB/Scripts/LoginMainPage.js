var finderr = false;
$(document).ready(function () {

   


    $(function () {
        $("#valiCode").bind("click", function () {
            this.src = "/Login/GetValidateCode?time=" + (new Date()).getTime();
        });

        $("#valiCode").click();
        $("#Myform").validate();
        $('#Myform').ajaxForm();
        $('#Myform').submit(MyAjax);
        $('#inputyanzhengma').bind("propertychange input", function () { checkyanzhengma(); });
        $("#myAlert").hide();

    });
    function alertshow() {
        $("#myAlert").show();   
    }
    function checkyanzhengma() {
        if ($('#inputyanzhengma').val().length <4) {
            $("#myAlert").hide();
            return false;
        }

        $.ajax({
            //需要使用post提交
            type: "post",
            url: "/Login/CheckYanZhengMa",
            data: "yzm=" + $('#inputyanzhengma').val(),
            async: true, //异步
            cache: false, //不加载缓存
            //dataType: "json",//对象为json
            success: function (e) {
                if (e == "true") {
                    $("#myAlert").removeClass("alert-danger");
                    $("#myAlert").addClass("alert-success");
                    $("#ajaxresult").html("验证码正确！");
                    alertshow();
                    finderr = false;
                } else {
                    $("#myAlert").removeClass("alert-success");
                    $("#myAlert").addClass("alert-danger");
                    $("#ajaxresult").html(e);
                    finderr = true;
                    alertshow();
                }

            },
            error: function (err) {
                MakeYZM();
                $("#myAlert").removeClass("alert-success");
                $("#myAlert").addClass("alert-danger");
                $("#ajaxresult").html("访问出错请联系管理员!");
                alertshow();
            }

        });
        return false;
    }
    function MakeYZM() {

        $("#valiCode").click();

    }
    function MyAjax() {
        if (finderr == true) {
            MakeYZM();
            $("#myAlert").removeClass("alert-success");
            $("#myAlert").addClass("alert-danger");
            $("#ajaxresult").html("请填写正确后提交！");

            alertshow();
            return false;
        }
        checkyanzhengma();
        $(this).ajaxSubmit();
        $.ajax({
            //需要使用post提交
            type: "post",
            url: "/Login/CheckLogin",
            data: $('#Myform').serialize(),
            async: true, //异步
            cache: false, //不加载缓存
            //dataType: "json",//对象为json
            success: function (e) {
                if (e == "loginok") {
                    $("#buttonsubmit").attr("disabled", true);
                    $("#myAlert").removeClass("alert-danger");
                    $("#myAlert").addClass("alert-success");
                    $("#ajaxresult").html("登陆成功！正在转向主页面请稍后!");
                    alertshow();
                    window.location.href = "/Student/Main";
                }
                else {
                    MakeYZM();
                    finderr = true;
                    $('#inputyanzhengma').val("");
                    $('#inputyanzhengma').focus();
                    $("#myAlert").removeClass("alert-success");
                    $("#myAlert").addClass("alert-danger");
                    $("#ajaxresult").html(e);
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                $("#myAlert").removeClass("alert-success");
                $("#myAlert").addClass("alert-danger");
                $("#ajaxresult").html("访问出错请联系管理员!出错信息:" + XMLHttpRequest.status + "," + XMLHttpRequest.readyState + "," + textStatus);
                alertshow();
                MakeYZM();
            }

        });
        return false;
    }
})