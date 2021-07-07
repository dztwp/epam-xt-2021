$("#UserAdd").click(function () {
    location.href = '/Pages/AddUserPage';
})
$("#AwardsListGetting").click(function () {
    location.href = '/Pages/AwardsListPage';
})
$("#ToIndex").click(function () {
    location.href = '/Pages/index';
})
$("#AwardAdd").click(function () {
    location.href = '/Pages/AddAwardPage';
})
$("#YesAnswer").click(function () {
    let message = document.getElementById("YesAnswer").value;
    location.href = '/Pages/DeleteAward' + '/?Id=' + message;
})
$("#NoAnswer").click(function () {
    location.href = '/Pages/index';
})