$(function () {
    /* jQueryKnob */

    $('.knob').knob({
        /*change : function (value) {
         //console.log("change : " + value);
         },
         release : function (value) {
         console.log("release : " + value);
         },
         cancel : function () {
         console.log("cancel : " + this.value);
         },*/
        draw: function () {

            // "tron" case
            if (this.$.data('skin') == 'tron') {

                var a = this.angle(this.cv)  // Angle
                    ,
                    sa = this.startAngle          // Previous start angle
                    ,
                    sat = this.startAngle         // Start angle
                    ,
                    ea                            // Previous end angle
                    ,
                    eat = sat + a                 // End angle
                    ,
                    r = true

                this.g.lineWidth = this.lineWidth

                this.o.cursor
                    && (sat = eat - 0.3)
                    && (eat = eat + 0.3)

                if (this.o.displayPrevious) {
                    ea = this.startAngle + this.angle(this.value)
                    this.o.cursor
                        && (sa = ea - 0.3)
                        && (ea = ea + 0.3)
                    this.g.beginPath()
                    this.g.strokeStyle = this.previousColor
                    this.g.arc(this.xy, this.xy, this.radius - this.lineWidth, sa, ea, false)
                    this.g.stroke()
                }

                this.g.beginPath()
                this.g.strokeStyle = r ? this.o.fgColor : this.fgColor
                this.g.arc(this.xy, this.xy, this.radius - this.lineWidth, sat, eat, false)
                this.g.stroke()

                this.g.lineWidth = 2
                this.g.beginPath()
                this.g.strokeStyle = this.o.fgColor
                this.g.arc(this.xy, this.xy, this.radius - this.lineWidth + 1 + this.lineWidth * 2 / 3, 0, 2 * Math.PI, false)
                this.g.stroke()

                return false
            }
        }
    })
    /* END JQUERY KNOB */

    //INITIALIZE SPARKLINE CHARTS
    var sparkline1 = new Sparkline($('#sparkline-1')[0], { width: 240, height: 70, lineColor: '#92c1dc', endColor: '#92c1dc' })
    var sparkline2 = new Sparkline($('#sparkline-2')[0], { width: 240, height: 70, lineColor: '#f56954', endColor: '#f56954' })
    var sparkline3 = new Sparkline($('#sparkline-3')[0], { width: 240, height: 70, lineColor: '#3af221', endColor: '#3af221' })

    sparkline1.draw([1000, 1200, 920, 927, 931, 1027, 819, 930, 1021])
    sparkline2.draw([515, 519, 520, 522, 652, 810, 370, 627, 319, 630, 921])
    sparkline3.draw([15, 19, 20, 22, 33, 27, 31, 27, 19, 30, 21])

})
