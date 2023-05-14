

    var month_normal = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]

    var date = new Date();
    var year = date.getFullYear();
    var month = date.getMonth();
    var day = date.getDay();   //星期幾
    var day1 = date.getDate(); //當天日期

    var holder = document.getElementById("day");


    //獲取當月第一天是星起幾
    function dateStart(month, year) {
        var tmpday = new Date(year, month, 1);
    return tmpday.getDay();
    }

    //當月天數
    function daymonth(month, year) {
        return month_normal[month];
    }

    function refreshDate() {

        //獲取該月天數
        var totalDay = daymonth(month, year);
    var firstDay = dateStart(month, year);
    var myclass;
    var str = "";

    for (var i = 1; i < firstDay + 1; i++) {
        str += "<li></li>";
        }

    for (var i = 1; i <= totalDay; i++) {
            if (i > day1) {
        myclass = " class='lightgrey'";
    str += "<li" + myclass + ">" + i + "</li>";
            }
            else {
    str += "<li>" + i + "</li>";
}
        }
holder.innerHTML = str;

    }

refreshDate(); //執行

function myfun() {
    var btn = document.querySelector('.button');
    var btn_text = document.getElementById("button");
    btn.style = "background-color:#FFF"
    btn_text.value = "已簽到"
    sign = true;
    refreshDate();
}



