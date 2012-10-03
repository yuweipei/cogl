/* This file has been generated by parse-gir.py, do not hand edit */
using System;
using System.Runtime.InteropServices;

namespace Cogl
{
    public partial class FrameBuffer
    {
        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_clear(IntPtr o, BufferBit buffers, ref Color color);

        public void Clear(BufferBit buffers, ref Color color)
        {
            cogl_framebuffer_clear(handle, buffers, ref color);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_clear4f(IntPtr o, BufferBit buffers, float red, float green, float blue, float alpha);

        public void Clear(BufferBit buffers, float red, float green, float blue, float alpha)
        {
            cogl_framebuffer_clear4f(handle, buffers, red, green, blue, alpha);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_discard_buffers(IntPtr o, BufferBit buffers);

        public void DiscardBuffers(BufferBit buffers)
        {
            cogl_framebuffer_discard_buffers(handle, buffers);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_draw_multitextured_rectangle(IntPtr o, IntPtr pipeline, float x_1, float y_1, float x_2, float y_2, float tex_coords, int tex_coords_len);

        public void DrawMultitexturedRectangle(Pipeline pipeline, float x_1, float y_1, float x_2, float y_2, float tex_coords, int tex_coords_len)
        {
            cogl_framebuffer_draw_multitextured_rectangle(handle, pipeline.Handle, x_1, y_1, x_2, y_2, tex_coords, tex_coords_len);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_draw_rectangle(IntPtr o, IntPtr pipeline, float x_1, float y_1, float x_2, float y_2);

        public void DrawRectangle(Pipeline pipeline, float x_1, float y_1, float x_2, float y_2)
        {
            cogl_framebuffer_draw_rectangle(handle, pipeline.Handle, x_1, y_1, x_2, y_2);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_draw_textured_rectangle(IntPtr o, IntPtr pipeline, float x_1, float y_1, float x_2, float y_2, float s_1, float t_1, float s_2, float t_2);

        public void DrawTexturedRectangle(Pipeline pipeline, float x_1, float y_1, float x_2, float y_2, float s_1, float t_1, float s_2, float t_2)
        {
            cogl_framebuffer_draw_textured_rectangle(handle, pipeline.Handle, x_1, y_1, x_2, y_2, s_1, t_1, s_2, t_2);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_draw_textured_rectangles(IntPtr o, IntPtr pipeline, float coordinates, uint n_rectangles);

        public void DrawTexturedRectangles(Pipeline pipeline, float coordinates, uint n_rectangles)
        {
            cogl_framebuffer_draw_textured_rectangles(handle, pipeline.Handle, coordinates, n_rectangles);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_finish(IntPtr o);

        public void Finish()
        {
            cogl_framebuffer_finish(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_frustum(IntPtr o, float left, float right, float bottom, float top, float z_near, float z_far);

        public void Frustum(float left, float right, float bottom, float top, float z_near, float z_far)
        {
            cogl_framebuffer_frustum(handle, left, right, bottom, top, z_near, z_far);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_alpha_bits(IntPtr o);

        public int GetAlphaBits()
        {
            return cogl_framebuffer_get_alpha_bits(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_blue_bits(IntPtr o);

        public int GetBlueBits()
        {
            return cogl_framebuffer_get_blue_bits(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern ColorMask cogl_framebuffer_get_color_mask(IntPtr o);

        public ColorMask GetColorMask()
        {
            return cogl_framebuffer_get_color_mask(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern IntPtr cogl_framebuffer_get_depth_texture(IntPtr o);

        public Texture GetDepthTexture()
        {
            IntPtr p = cogl_framebuffer_get_depth_texture(handle);
            return new Texture(p);
        }

        [DllImport("cogl2.dll")]
        public static extern bool cogl_framebuffer_get_depth_texture_enabled(IntPtr o);

        public bool GetDepthTextureEnabled()
        {
            return cogl_framebuffer_get_depth_texture_enabled(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern bool cogl_framebuffer_get_dither_enabled(IntPtr o);

        public bool GetDitherEnabled()
        {
            return cogl_framebuffer_get_dither_enabled(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern PixelFormat cogl_framebuffer_get_color_format(IntPtr o);

        public PixelFormat GetColorFormat()
        {
            return cogl_framebuffer_get_color_format(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_green_bits(IntPtr o);

        public int GetGreenBits()
        {
            return cogl_framebuffer_get_green_bits(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_height(IntPtr o);

        public int GetHeight()
        {
            return cogl_framebuffer_get_height(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_get_modelview_matrix(IntPtr o);

        public void GetModelviewMatrix()
        {
            cogl_framebuffer_get_modelview_matrix(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_get_projection_matrix(IntPtr o);

        public void GetProjectionMatrix()
        {
            cogl_framebuffer_get_projection_matrix(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_red_bits(IntPtr o);

        public int GetRedBits()
        {
            return cogl_framebuffer_get_red_bits(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_samples_per_pixel(IntPtr o);

        public int GetSamplesPerPixel()
        {
            return cogl_framebuffer_get_samples_per_pixel(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_get_viewport4fv(IntPtr o);

        public void GetViewport4fv()
        {
            cogl_framebuffer_get_viewport4fv(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern float cogl_framebuffer_get_viewport_height(IntPtr o);

        public float GetViewportHeight()
        {
            return cogl_framebuffer_get_viewport_height(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern float cogl_framebuffer_get_viewport_width(IntPtr o);

        public float GetViewportWidth()
        {
            return cogl_framebuffer_get_viewport_width(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern float cogl_framebuffer_get_viewport_x(IntPtr o);

        public float GetViewportX()
        {
            return cogl_framebuffer_get_viewport_x(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern float cogl_framebuffer_get_viewport_y(IntPtr o);

        public float GetViewportY()
        {
            return cogl_framebuffer_get_viewport_y(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern int cogl_framebuffer_get_width(IntPtr o);

        public int GetWidth()
        {
            return cogl_framebuffer_get_width(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_identity_matrix(IntPtr o);

        public void IdentityMatrix()
        {
            cogl_framebuffer_identity_matrix(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_orthographic(IntPtr o, float x_1, float y_1, float x_2, float y_2, float near, float far);

        public void Orthographic(float x_1, float y_1, float x_2, float y_2, float near, float far)
        {
            cogl_framebuffer_orthographic(handle, x_1, y_1, x_2, y_2, near, far);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_perspective(IntPtr o, float fov_y, float aspect, float z_near, float z_far);

        public void Perspective(float fov_y, float aspect, float z_near, float z_far)
        {
            cogl_framebuffer_perspective(handle, fov_y, aspect, z_near, z_far);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_pop_clip(IntPtr o);

        public void PopClip()
        {
            cogl_framebuffer_pop_clip(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_pop_matrix(IntPtr o);

        public void PopMatrix()
        {
            cogl_framebuffer_pop_matrix(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_push_matrix(IntPtr o);

        public void PushMatrix()
        {
            cogl_framebuffer_push_matrix(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_push_rectangle_clip(IntPtr o, float x_1, float y_1, float x_2, float y_2);

        public void PushRectangleClip(float x_1, float y_1, float x_2, float y_2)
        {
            cogl_framebuffer_push_rectangle_clip(handle, x_1, y_1, x_2, y_2);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_push_scissor_clip(IntPtr o, int x, int y, int width, int height);

        public void PushScissorClip(int x, int y, int width, int height)
        {
            cogl_framebuffer_push_scissor_clip(handle, x, y, width, height);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_resolve_samples(IntPtr o);

        public void ResolveSamples()
        {
            cogl_framebuffer_resolve_samples(handle);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_resolve_samples_region(IntPtr o, int x, int y, int width, int height);

        public void ResolveSamplesRegion(int x, int y, int width, int height)
        {
            cogl_framebuffer_resolve_samples_region(handle, x, y, width, height);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_rotate(IntPtr o, float angle, float x, float y, float z);

        public void Rotate(float angle, float x, float y, float z)
        {
            cogl_framebuffer_rotate(handle, angle, x, y, z);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_scale(IntPtr o, float x, float y, float z);

        public void Scale(float x, float y, float z)
        {
            cogl_framebuffer_scale(handle, x, y, z);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_color_mask(IntPtr o, ColorMask color_mask);

        public void SetColorMask(ColorMask color_mask)
        {
            cogl_framebuffer_set_color_mask(handle, color_mask);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_depth_texture_enabled(IntPtr o, bool enabled);

        public void SetDepthTextureEnabled(bool enabled)
        {
            cogl_framebuffer_set_depth_texture_enabled(handle, enabled);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_dither_enabled(IntPtr o, bool dither_enabled);

        public void SetDitherEnabled(bool dither_enabled)
        {
            cogl_framebuffer_set_dither_enabled(handle, dither_enabled);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_modelview_matrix(IntPtr o, ref Matrix matrix);

        public void SetModelviewMatrix(ref Matrix matrix)
        {
            cogl_framebuffer_set_modelview_matrix(handle, ref matrix);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_projection_matrix(IntPtr o, ref Matrix matrix);

        public void SetProjectionMatrix(ref Matrix matrix)
        {
            cogl_framebuffer_set_projection_matrix(handle, ref matrix);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_samples_per_pixel(IntPtr o, int samples_per_pixel);

        public void SetSamplesPerPixel(int samples_per_pixel)
        {
            cogl_framebuffer_set_samples_per_pixel(handle, samples_per_pixel);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_set_viewport(IntPtr o, float x, float y, float width, float height);

        public void SetViewport(float x, float y, float width, float height)
        {
            cogl_framebuffer_set_viewport(handle, x, y, width, height);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_transform(IntPtr o, ref Matrix matrix);

        public void Transform(ref Matrix matrix)
        {
            cogl_framebuffer_transform(handle, ref matrix);
        }

        [DllImport("cogl2.dll")]
        public static extern void cogl_framebuffer_translate(IntPtr o, float x, float y, float z);

        public void Translate(float x, float y, float z)
        {
            cogl_framebuffer_translate(handle, x, y, z);
        }

    }
}
