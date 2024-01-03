function sendProfileMsg(text) {
	var data = {
		userid: anketaUserId,
		msg: text
	};
	data["token"] = token;
	$.post(sendProfileMsgUrl,
		data,
		function(data) {
			if (data.complete) {
				getAllProfileMsgs();
			}
		},
		"json"
	);
}
