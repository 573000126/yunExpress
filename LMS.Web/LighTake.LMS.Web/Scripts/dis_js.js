
	function dis_scecondmenu(id) {
	     
		if(document.getElementById(id).className=="selected")
		{
			document.getElementById(id).className = "un_selected";
			document.getElementById(id+"_inbox").style.display = "none";
		}
		else{
			document.getElementById(id).className = "selected";
			document.getElementById(id+"_inbox").style.display = "block";
		}
		
		
	}
	function dis_thirdmenu(id)
	{
		if(document.getElementById(id+"_thirdmenu").style.display =="block")
		{
			document.getElementById(id+"_thirdmenu").style.display = "none";

		}
		else{
			document.getElementById(id+"_thirdmenu").style.display = "block";
		}
	}
	function dis_pm_table(id)
	{
		document.getElementById(id+"_div").style.display = "block";

}

(function ($) {
    $.fn.extend({
        "SetTableBgColor": function (options) {
            option = $.extend({
                Odd: "data_row_shuang", //����
                Even: "data_row_dan", //ż��
                Selected: "tb_Selected", //ѡ��
                Over: "tb_Over" //�������ȥ
            }, options);  //�˴�options��function��Ĳ���Ϊͬһ������
            //���л�ɫ
            $("tbody > tr:even", this).addClass(option.Even);
            $("tbody > tr:odd", this).addClass(option.Odd);
            //�������ȥ
            $("tbody > tr", this).mouseover(function () {
               
                if ($(this).hasClass(option.Selected) == false) {
                    $(this).addClass(option.Over);
                }
            });
            //����Ƴ�
            $("tbody > tr", this).mouseout(function () {
                $(this).removeClass(option.Over);
            });
            //������ɫ
            $("tbody > tr", this).click(function () {
                $("tbody > tr").removeClass(option.Over);
                if ($(this).hasClass(option.Selected) == false) {
                    $(this).addClass(option.Selected);
                } else {
                    $(this).removeClass(option.Selected);
                }
            });

            return this;
        }
    });
})(jQuery);

    $(function () {
        $("table").SetTableBgColor();

    
    });



