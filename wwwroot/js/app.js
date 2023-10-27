
document.querySelector("#burger").addEventListener('click', function() {
   document.querySelector("#shadow").classList.add("shadow");
    document.querySelector("#hide-menu").style.transform= "translateX(1%)";
});
document.querySelector("#xmark-icon").addEventListener('click', function() {
    document.querySelector("#hide-menu").style.transform= "translateX(-100%)";
    document.querySelector("#shadow").classList.remove("shadow");
});
document.querySelector("#user-phone-btn").addEventListener('click', function(e){


    let userPhone= document.querySelector("#user-phone");
    let value= userPhone.value;
    
    try{
        if(value ===" ") throw "شماره همراه خود را وارد کنید";
        if(isNaN(value)) throw "رقم وارد کنید";
        if (12 < value.length < 11) throw "رقم وارد شده صحیح نمی باشد.";

        value=Number(value);
    }catch(err) {
        alert(err);
    }finally{
        document.querySelector("#user-phone").value =="";
    }
    e.preventDefault();
});


let upBtn =document.querySelector(".up-arrow");
let header= document.querySelector("#header");

function handleScrollingPage() {
    upBtn.style.display= "block";
}
upBtn.addEventListener('click', function() {
    window.scrollBy(0, -1000000);
});

// the codes for register form.
function showForm() {
    document.querySelector("#shadow").classList.add("shadow");
   document.querySelector("#register-form").style.display= "block";
}
function hideForm() {
    document.querySelector("#register-form").style.display= "none";
    document.querySelector("#shadow").classList.remove("shadow");
}


