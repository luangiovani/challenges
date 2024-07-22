$(document).ready(function(){

  var noteCount = 0;
  var activeNote = null;
  var color = "#FFFFFF";
  $('.list-colors div').click(function(){ 
	color = $(this).data('value');
    $('#body-field').css('background-color', color);
  });

  $('#btn-save').click(function(){
    var body = $('#body-field').val();
    if (body === '') {
		$('.danger').html('* Please add a note.');
		return;
    } else {
		$('.danger').html('');
	}
	
	if($(".note-list").removeClass('no-display'));
	
    var created = new Date();
    var id = noteCount + 1;
    if (activeNote) {
      $('#' + activeNote)[0].children[0].innerHTML = created.toLocaleString("en-US");
      $('#' + activeNote)[0].children[1].innerHTML = body;
      $('#' + activeNote)[0].style.backgroundColor = color;
      activeNote = null;
    } else {
      var created = new Date();
      $('#saved-notes').append('<div id="note' + id + '" class="note-item" style="background-color: ' + color + '; cursor: pointer;"><div class="note-date">' + created.toLocaleString("en-US") + '</div> <div class="note-text">' + body + '</div> </div>');
      noteCount++;
    };
    $('#body-field').val('');
    $('#body-field').css('background-color', '#FFFFFF');
	color = "#FFFFFF";
  });

  $('#btn-delete').click(function(){
    if (activeNote) {
      $('#' + activeNote)[0].remove();
      activeNote = null;
	  noteCount--;
    }
      $('#body-field').val('');
      $('#body-field').val('');
	  $('#body-field').css('background-color', '#FFFFFF');
	  color = "#FFFFFF";
	  if(noteCount<= 0){
		  $(".note-list").addClass('no-display')
	  };
  });

  $('#saved-notes').click(function(e){
    var id = e.target.parentElement.id;
    activeNote = id;
    var bodySel = $('#' + id + ' .note-text').html();
	color = e.target.parentElement.style.backgroundColor;
    $('#body-field').val(bodySel);
    $('#body-field').css('background-color', color);
  })

})