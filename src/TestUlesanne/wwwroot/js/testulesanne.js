$(document).ready(function () {
    $('#userschoices').focus();

    $('#savebutton').on('click', function (event) {
        if (!validateData()) {
            return;
        }

        var dfd = jQuery.Deferred();
        var sectorsUrl = 'Sector/Save';
        var usersChoiceViewModel = getUsersChoicesJson();

        var usersChoices = $.ajax({
            url: sectorsUrl,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            data: {
                'userId': usersChoiceViewModel.User.Id,
                'userName': usersChoiceViewModel.User.Name,
                'usersChoices': usersChoiceViewModel.UsersChoices.join()
            }
        });

        $.when(usersChoices).done(function (usersChoiceViewModel) {
            dfd.resolve(usersChoiceViewModel);
            setUsersChoices(usersChoiceViewModel)
        });

        return dfd.promise();
    });

    $('#User_Name').on('blur', function (event) {
        getUsersChoicesByName();
    });

    $('#User_Name').on('keydown', function (event) {
        switch (event.keyCode) {
            case 13:
                event.preventDefault();
                getUsersChoicesByName();
                break;
        }
    });

    setautocomplete();

    function getUsersChoicesByName() {
        var dfd = jQuery.Deferred();
        var sectorsUrl = 'Sector/UsersChoicesByName';

        var usersChoices = $.ajax({
            url: sectorsUrl,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            data: {
                'userName': $('#User_Name').val()
            }
        });

        $.when(usersChoices).done(function (usersChoiceViewModel) {
            dfd.resolve(usersChoiceViewModel);
            setUsersChoices(usersChoiceViewModel)
        });

        return dfd.promise();
    }

    function getUsersChoicesJson() {
        var user = { Id: $('#User_Id').val() * 1, Name: $('#User_Name').val() };
        var usersChoices = [];

        for (var i = 0; i < $('#userschoices').find('option:selected').length; i++)
        {
            var $option = $('#userschoices').find('option:selected')[i];
            usersChoices.push($option.value * 1);
        }

        return { User: user, UsersChoices: usersChoices };
    }

    function setUsersChoices(usersChoiceViewModel)
    {
        $('#User_Id').val(usersChoiceViewModel.user.id);

        if (usersChoiceViewModel.user.id * 1 !== 0) {
            $('#User_Name').val(usersChoiceViewModel.user.name);
        }

        var selected = [];

        $("#userschoices").val([]);
        for (var i = 0; i < usersChoiceViewModel.usersChoices.length; i++) {
            if (usersChoiceViewModel.usersChoices[i].selected) {
                selected.push(usersChoiceViewModel.usersChoices[i].sectorId);
            }
        }
        $("#userschoices").val(selected);
        $('#userschoices').focus();

        setautocomplete();
        scrollToFirstSelected();

        $('.form-check-input')[0].checked = false;
    }

    function setautocomplete() {
        var dfd = jQuery.Deferred();
        var sectorsUrl = 'Sector/getUsers';

        var users = $.ajax({
            url: sectorsUrl,
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
        });

        $.when(users).done(function (users) {
            dfd.resolve(users);
            $("#User_Name").autocomplete({
                source: users
            });
        });

        return dfd.promise();
    }

    function scrollToFirstSelected() {
        var selectedValue = $('#userschoices').find('option:selected').length === 0 
            ? $('#userschoices').find('option')[0].value
            : $('#userschoices').find('option:selected')[0].value;

        var optionTop = $('#userschoices').find('[value="' + selectedValue + '"]').offset().top;
        var selectTop = $('#userschoices').offset().top;

        $('#userschoices').scrollTop($('#userschoices').scrollTop() + (optionTop - selectTop));
    }

    function validateData() {
        var html = "";

        $('.text-danger').find('ul').find('li').remove();

        if ($('#User_Name').val() === '') {
            html += "<li>User's name is required.</li>";
        }

        if ($('.form-check-input')[0].checked === false) {
            html += "<li>Agree to terms is required.</li>";
        }

        if (html !== '') {
            $('.text-danger').find('ul').append(html);
            return false;
        }

        return true;
    }
});
