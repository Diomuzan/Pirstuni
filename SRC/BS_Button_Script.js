function myFunction() {
    alert('Er is op de button geklikt');
}

const myBtn = document.querySelector('.Button');
myBtn.addEventListener('click', myFunction)

const myDiv = document.querySelector('.change-color');
if (myBtn) {
    console.log(myBtn);
} else {
    console.log('Het element bestaat niet');
}