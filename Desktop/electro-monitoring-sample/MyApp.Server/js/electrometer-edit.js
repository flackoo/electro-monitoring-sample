$(document).ready(function () {
  (function autoSelectModel() {
    let panel = $('#model-panel');
    let model = panel.attr('data-model');

    panel.find(`input[type="radio"][value="Schneider.${model}"]`).attr('checked', 'checked');
  })();
});