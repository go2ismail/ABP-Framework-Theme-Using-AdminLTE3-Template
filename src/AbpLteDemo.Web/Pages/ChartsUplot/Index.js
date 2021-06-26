$(function () {
    /* uPlot
     * -------
     * Here we will create a few charts using uPlot
     */

    function getSize(elementId) {
        return {
            width: document.getElementById(elementId).offsetWidth,
            height: document.getElementById(elementId).offsetHeight,
        }
    }

    let data = [
        [0, 1, 2, 3, 4, 5, 6],
        [28, 48, 40, 19, 86, 27, 90],
        [65, 59, 80, 81, 56, 55, 40]
    ];

    //--------------
    //- AREA CHART -
    //--------------

    const optsAreaChart = {
        ...getSize('areaChart'),
        scales: {
            x: {
                time: false,
            },
            y: {
                range: [0, 100],
            },
        },
        series: [
            {},
            {
                fill: 'rgba(60,141,188,0.7)',
                stroke: 'rgba(60,141,188,1)',
            },
            {
                stroke: '#c1c7d1',
                fill: 'rgba(210, 214, 222, .7)',
            },
        ],
    };

    let areaChart = new uPlot(optsAreaChart, data, document.getElementById('areaChart'));

    const optsLineChart = {
        ...getSize('lineChart'),
        scales: {
            x: {
                time: false,
            },
            y: {
                range: [0, 100],
            },
        },
        series: [
            {},
            {
                fill: 'transparent',
                width: 5,
                stroke: 'rgba(60,141,188,1)',
            },
            {
                stroke: '#c1c7d1',
                width: 5,
                fill: 'transparent',
            },
        ],
    };

    let lineChart = new uPlot(optsLineChart, data, document.getElementById('lineChart'));

    window.addEventListener("resize", e => {
        areaChart.setSize(getSize('areaChart'));
        lineChart.setSize(getSize('lineChart'));
    });
})