// JavaScript source code
function getStyle(obj, attr) {      //  ����Ԫ������ֵ
    if (obj.currentStyle) {
        return obj.currentStyle[attr];      //  IE6~8�л��Ԫ������ֵ
    }
    else {
        return getComputedStyle(obj, null)[attr];   //  IE9��Chrome��Firefox�������ȡԪ������ֵ
    }
}

//  function moveFunc(obj, attr, iTarget, newFunc) {     //  �˶�������ܣ��˴�json�β����ڴ���json��ʽ������
function moveFunc(obj, json, newFunc) {
    clearInterval(obj.timer);               //  �Ƚ��������һ����ʱ���ر�
    obj.timer = setInterval(function () {     //  ���ö�ʱ��
        for (var attr in json) {
            var cur;                            //  ����һ��cur���������ڸ�ֵ�������Եĵ�ǰֵ
            //  ��������Ϊopacity�����������õ�ǰ����ֵ
            if (attr == "opacity") {
                //  Math.round()���������������룬opacity����ֵΪС����������parseFloatת��Ϊ������
                cur = Math.round(parseFloat(getStyle(obj, attr)) * 100);
            }
            else {
                //  ���Բ���opacityʱ��ֱ�ӶԷ��صĽ������parseIntת��Ϊ����
                cur = parseInt(getStyle(obj, attr));
            }
            var speed = (json[attr] - cur) / 6;      //  ��iTarget��ȥcur��ǰ����ֵ��Ȼ���6������speed���˴���json[attr]����iTarget��attrΪ��������json[attr]��ʾ���Զ�Ӧ��ֵ
            //  �Եõ���speed����ȡ����speed����0ʱ��ʹ��Math.ceil()������������ȡ����ֵ��
            //  speedС��0ʱ��ʹ��Math.floor()������������ȡ����ֵ
            speed = speed > 0 ? Math.ceil(speed) : Math.floor(speed);

            //  Ȼ��Ե�ǰֵ��Ŀ��ֵ���бȽϣ������ֹͣ��ʱ�����������Ե�ǰֵ��������
            if (cur == json[attr]) {
                clearInterval(obj.timer);
                if (newFunc) { newFunc(); }      //  �ڶ�ʱ�����н����󣬶�newFunc�����жϣ�������newFunc�������newFunc��������û�д���newFunc����ִ��
            }
            else {
                if (attr == "opacity") {
                    obj.style["filter"] = "alpha(opacity=" + (cur + speed) + ");";
                    obj.style[attr] = (cur + speed) / 100;
                }
                else {
                    obj.style[attr] = cur + speed + "px";
                }
            }
        }
    }, 30);
}