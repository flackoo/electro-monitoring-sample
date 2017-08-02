let tempData;
$(document).ready(function() {  
 $('.electrometer-select .electrometers-container').perfectScrollbar();
  $('.electrometers-container .electrometer-option').click(function () {
    $('#electrometer-name').html($(this).html());
    $('.electrometers-container .selected').removeClass('selected');
    $(this).addClass('selected');

    loadDailyInquiry($(this).attr('data-id'));
  });

  function loadDailyInquiry(id) {
    let request = {
      url: `/inquiry/daily/${id}`,
      method: 'get'
    }
    $.ajax(request)
      .done(function(result) { tempData = result; visualizeData(); })
      .error(function (result) { helpers.showMessage('error', 'An error occurred', true, 0); });
  }

  function visualizeData(type) {
    let activeEnergy = [],
        reactiveEnergy = [],
        activePower = [],
        reactivePower = [],
        dateAxis = [];

    switch(type) {
      case 'table': 
        let mytable = $('<table class="table table-striped data-visualized-table table-hover">'),
            thead = $('<thead>').append([
              '<tr><h2>All data uses unit <b>kWh</b></h2></tr>',
              '<tr>',
              '<th style="padding-left:10px">#</th>',
              '<th>Date</th>',
              '<th>Active Power</th>',
              '<th>Reactive Power</th>',
              '<th>Active Energy</th>',
              '<th>Reactive Energy</th>',
              '</tr>'
            ]),
            tbody = $('<tbody>');

        for(let i = 0; i < tempData.length; i++) {
          let row = $('<tr>').append([
            `<td>${i + 1}</td>`,
            `<td>${tempData[i].DateTime}</td>`,
            `<td>${tempData[i].KW}</td>`,
            `<td>${tempData[i].KVA}</td>`,
            `<td>${tempData[i].ActiveEnergy}</td>`,
            `<td>${tempData[i].ReactiveEnergy}</td>`
          ]);
          tbody.append(row);
        }
        
        $('#line-chart-map').remove();
        mytable.append([thead, tbody]).insertAfter('.data-visualize-list')

        break;

      case 'chart':
      default:
        $('#line-chart-map').remove();
        let chart = $('<canvas id="line-chart-map" width="600" height="350">');
        chart.appendTo($('.chart-container'));

        for (let i = 1; i < tempData.length; i++) {
          activeEnergy.push(tempData[i].ActiveEnergy - tempData[i - 1].ActiveEnergy);
          reactiveEnergy.push(tempData[i].ReactiveEnergy - tempData[i - 1].ReactiveEnergy);
          activePower.push(tempData[i].KW - tempData[i - 1].KW);
          reactivePower.push(tempData[i].KVA - tempData[i - 1].KVA);
          dateAxis.push(tempData[i].DateTime);
        }

        new Chart($('#line-chart-map'), {
          type: 'line',
          data: {
            labels: dateAxis,
            datasets: [{
              data: activeEnergy,
              label: 'Active Energy',
              borderColor: '#3e95cd',
              fill: false
            },
            {
              data: reactiveEnergy,
              label: 'Reactive Energy',
              borderColor: '#8e5ea2',
              fill: false
            },
            {
              data: activePower,
              label: 'Active Power',
              borderColor: '#23e039',
              fill: false
            },
            {
              data: reactivePower,
              label: 'Reactive Power',
              borderColor: '#e0c923',
              fill: false
            }]
          },
          options: {
            title: {
              display: true,
              text: 'Electrometer Consumption Data'
            }
          }
        });
        $('.data-visualized-table').remove();
        break;
    }

    $('.data-visualize-list').removeAttr('style');
    $('#datetimepicker5').datetimepicker();
  }

  $('.data-visualize-list li').click(function () {
    $('.data-visualize-list li.active').removeClass('active');
    $(this).addClass('active');
    visualizeData($(this).attr('data-type'));
  })
});