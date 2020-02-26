var dataJson = localStorage.getItem('MyFormData');
var data = JSON.parse(dataJson);
console.log(data);
data.forEach(x => {
    var div = document.createElement("div");
    div.innerHTML = `
    <div class="form-group">
                <label for="${x.name}">${x.name} </label>
                <input type="text" value="${x.value}" id="${x.name}" class="form-control" disabled />
    </div>
    `;
    document.getElementById("divDisplay").appendChild(div);
});