// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(".appointment tbody a").click(function(){
   var name =  $(this).data("name");
   var date =  $(this).data("date");
   var organizer =  $(this).data("organizer");
   var subject =  $(this).data("subject");
   var attendee =  $(this).data("attendees").trim().split(",").filter(item => item);

   var detail =  $(".appointmentDetail");

   detail.find(".desc").text(name);
   detail.find(".date").text(date);
   detail.find(".organizer").text(organizer);
   detail.find(".subject").text(subject); 
   detail.find(".attendee table tr").remove();
   attendee.map((name)=>{
        $(".attendee table").append(`<tr><td>${name}</td></tr>`);
   })

   if(attendee.length == 0){
    $(".attendee table").append(`<tr><td>No Attendee</td></tr>`);
   }

   $(".appointmentDetail").fadeIn()
})