var button=document.querySelector('#fullscreen');button.addEventListener('click',fullscreen);document.addEventListener('webkitfullscreenchange',fullscreenChange);document.addEventListener('mozfullscreenchange',fullscreenChange);document.addEventListener('fullscreenchange',fullscreenChange);document.addEventListener('MSFullscreenChange',fullscreenChange);function fullscreen(){if(document.fullscreenEnabled||document.webkitFullscreenEnabled||document.mozFullScreenEnabled||document.msFullscreenEnabled){var iframe=document.querySelector('#frame');if(iframe.requestFullscreen){iframe.requestFullscreen()}else if(iframe.webkitRequestFullscreen){iframe.webkitRequestFullscreen()}else if(iframe.mozRequestFullScreen){iframe.mozRequestFullScreen()}else if(iframe.msRequestFullscreen){iframe.msRequestFullscreen()}}
else{document.querySelector('.error').innerHTML='Your browser is not supported'}}
function fullscreenChange(){if(document.fullscreenEnabled||document.webkitIsFullScreen||document.mozFullScreen||document.msFullscreenElement){console.log('enter fullscreen')}
else{console.log('exit fullscreen')}
var iframe=document.querySelector('iframe');iframe.src=iframe.src}
function PrintElem(el){var restorepage=document.body.innerHTML;var printcontent=document.getElementById(el).innerHTML;document.body.innerHTML=printcontent;window.print();document.body.innerHTML=restorepage;window.location.reload()}
