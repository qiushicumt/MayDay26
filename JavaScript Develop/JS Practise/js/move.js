/**
 * Created by MayDay26 on 2015/9/22.
 */
function getStyle(obj, attr) {
    if(obj.currentStyle) {
        return obj.currentStyle[attr];
    }
    else {
        return getComputedStyle(obj, null)[attr];
    }
}
function moveFunc(obj, attr, iTarget) {
    clearInterval(obj.timer);
    obj.timer = setInterval(function(){
        var cur;
        if(attr == 'opacity') {
            cur = Math.round(parseFloat(getStyle(obj, attr))*100);
        }
        else {
            cur = parseInt(getStyle(obj, attr));
        }
        var speed = (iTarget - cur)/6;
        speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);
        if(cur == iTarget) {
            clearInterval(obj.timer);
        }
        else {
            if(attr == 'opacity') {
                obj.style['filter'] = 'alpha(opacity:' + (cur + speed) + ');';
                obj.style[attr] = (cur + speed)/100;
            }
            else {
                obj.style[attr] = cur + speed + 'px';
            }
        }
    }, 30);
}