import ffmpeg 

#data from pipeline coming from C#
input_file = "" #path, prolly gotta import OS
vid_bitrate = 0
aud_bitrate = 0
res_width = 0
res_height = 0
user_fps = 0
user_format_bin = 3 #whatever variable fits

def zero():
    return "mp4"

def one():
    return "mov"

def two():
    return "avi"

struct = {
    0: zero,
    1: one,
    2: two
}

user_format = struct.get(user_format_bin, lambda: "Unsupported extension type")()

print(f"Variable name returned: {user_format}")

test = (
    ffmpeg
    .input(input_file)
    .filter('fps', fps = user_fps)
    .output(f"{input_file}/.{user_format}")
)