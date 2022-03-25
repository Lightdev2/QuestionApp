<template>
  <label class="input">
    <div class="input__label">
      <slot name="label"></slot>
    </div>
    <input class="input__input" type="text" :placeholder="$props?.placeholder" />
  </label>
</template>

<script>
export default {
  name: "QInput",
  props: ['placeholder']
};
</script>

<style scoped lang="scss">
.input {
  display: flex;
  flex-direction: column;
  &__input {
    margin-top: 5px;
    border-radius: 0.2rem;
    background-color: transparent;
    border: 1px solid var(--black);
    color: var(--black700);
    padding: 5px;
  }
  &__label {
    font-size: 18px;
    font-weight: 500;
    color: var(--black700);
  }
}
</style>
