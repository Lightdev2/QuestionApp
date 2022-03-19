<template>
  <div class="input">
    <div class="input__top">
      <input v-model="tag" class="input__input" type="text" />
      <button class="input__btn" @click="emitTag">+</button>
    </div>
  </div>
</template>

<script>
export default {
  name: "AddInput",
};
</script>

<script setup>
import { defineEmits, ref } from "vue";
const tag = ref("");
const emits = defineEmits(["addTag"]);
const emitTag = () => {
  emits("addTag", tag.value);
  tag.value = "";
};
</script>

<style scoped lang="scss">
.input {
  position: relative;
  width: 100%;
  &__top {
    height: 35px;
    display: flex;
  }
  &__input {
    background: transparent;
    border: 1px solid var(--black200);
    border-top-left-radius: 5px;
    border-bottom-left-radius: 5px;
    border-right: none;
    color: var(--black900);
    font-size: 14px;
    width: 100%;
  }
  &__dropdown {
    position: absolute;
    z-index: 999;
    background-color: var(--black);
    width: 100%;
    top: 30 px;
    border: 1px solid var(--black900);
    border-radius: 5px;
  }
  &__btn {
    background: var(--blue500);
    border: none;
    color: var(--black900);
    border-top-right-radius: 5px;
    cursor: pointer;
    border-bottom-right-radius: 5px;
    &:hover {
      background-color: var(--blue600);
    }
  }
}
</style>
