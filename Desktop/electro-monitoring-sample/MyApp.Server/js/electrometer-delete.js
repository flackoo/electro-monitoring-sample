$(document).ready(function () {
  $('.electrometer-delete').click(function (ev) {
    ev.preventDefault();

    let id = $(ev.target).attr('data-id');

    $.confirm({
      title: 'Are you sure you want to delete this electrometer?',
      content: '',
      type: 'red',
      buttons: {
        confirm: {
          btnClass: 'btn-red',
          action: function () {
            deleteElectrometer(id);
          }
        },
        cancel: function () { }
      }
    });
  });

  function deleteElectrometer(id) {
    let request = {
      url: `/electrometers/delete/${id}`,
      method: 'post',
      data: {}
    };
    $.ajax(request)
      .done(function(result) { 
        if(result.success === true) {
          helpers.showMessage('success', 'Successfully deleted electrometer.', false, 3000);
          $('#electrometer-' + id).remove();
        }         
        else {
          helpers.showMessage('warning', `An error occured while trying to delete this electometer. <br>The server said: ${result.message}`, false, 5000);
        }
      })
      .error(function (err) {
        helpers.showMessage('warning', `An error occured while trying to delete this electometer. <br>The server said: ${err.responseText}`, false, 5000);        
      })
  }
});